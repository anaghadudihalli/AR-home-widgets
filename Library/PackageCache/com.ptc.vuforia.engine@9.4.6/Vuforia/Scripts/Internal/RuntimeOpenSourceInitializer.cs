/*===============================================================================
Copyright (c) 2019 PTC Inc. All Rights Reserved.

Confidential and Proprietary - Protected under copyright and other laws.
Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/

using System;
using UnityEngine;
using UnityEngine.EventSystems;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

namespace Vuforia.UnityRuntimeCompiled
{
    public class RuntimeOpenSourceInitializer
    {
        static IUnityRuntimeCompiledFacade sFacade;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void OnRuntimeMethodLoad()
        {
            InitializeFacade();
        }

        static void InitializeFacade()
        {
            if (sFacade != null) return;

            sFacade = new OpenSourceUnityRuntimeCompiledFacade();
            UnityRuntimeCompiledFacade.Instance = sFacade;
        }

        class OpenSourceUnityRuntimeCompiledFacade : IUnityRuntimeCompiledFacade
        {
            readonly IUnityRenderPipeline mUnityRenderPipeline = new UnityRenderPipeline();

            public IUnityRenderPipeline UnityRenderPipeline
            {
                get { return mUnityRenderPipeline; }
            }
            
            public bool IsUnityUICurrentlySelected()
            {
                return !(EventSystem.current == null || EventSystem.current.currentSelectedGameObject == null);
            }
        }

        class UnityRenderPipeline : IUnityRenderPipeline
        {
            public event Action<Camera[]> BeginFrameRendering;
            public event Action<Camera> BeginCameraRendering;

            public UnityRenderPipeline()
            {
#if UNITY_2018
                UnityEngine.Experimental.Rendering.RenderPipeline.beginFrameRendering += OnBeginFrameRendering;
                UnityEngine.Experimental.Rendering.RenderPipeline.beginCameraRendering += OnBeginCameraRendering;
#else
                UnityEngine.Rendering.RenderPipelineManager.beginFrameRendering += OnBeginFrameRendering;
                UnityEngine.Rendering.RenderPipelineManager.beginCameraRendering += OnBeginCameraRendering;
#endif
            }

#if UNITY_2018
            void OnBeginCameraRendering(Camera camera)
#else
            void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, Camera camera)
#endif
            {
                if (BeginCameraRendering != null)
                    BeginCameraRendering(camera);
            }

#if UNITY_2018
            void OnBeginFrameRendering(Camera[] cameras)
#else
            void OnBeginFrameRendering(UnityEngine.Rendering.ScriptableRenderContext context, Camera[] cameras)
#endif
            {
                if (BeginFrameRendering != null)
                    BeginFrameRendering(cameras);
            }
        }
    }
}
