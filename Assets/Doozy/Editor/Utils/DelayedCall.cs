

using System;
using UnityEditor;
using UnityEngine;

// ReSharper disable UnusedMethodReturnValue.Global

namespace Doozy.Editor.Utils
{
    /// <summary> Executes a delayed call in the Editor </summary>
    public class DelayedCall
    {
        private readonly float m_delay;
        private readonly Action m_callback;
        private readonly float m_startupTime;

        public DelayedCall(float delay, Action callback)
        {
            m_delay = delay;
            m_callback = callback;
            m_startupTime = Time.realtimeSinceStartup;
            EditorApplication.update += Update;
        }

        private void Update()
        {
            if (Time.realtimeSinceStartup - (double) m_startupTime < m_delay) return;
            if (EditorApplication.update != null) EditorApplication.update -= Update;
            if (m_callback != null) m_callback();
        }

       

        public void Cancel()
        {
            if (EditorApplication.update != null) EditorApplication.update -= Update;
        }
        
        public static DelayedCall Run(float delay, Action callback)
        {
            return new DelayedCall(delay, callback);
        }
    }
}