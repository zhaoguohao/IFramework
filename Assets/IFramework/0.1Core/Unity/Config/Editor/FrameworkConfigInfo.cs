﻿/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.1f1
 *Date:           2019-03-22
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;
using UnityEngine;
namespace IFramework
{
    [Serializable]
    class FrameworkConfigInfo : ScriptableObject
    {
        public string FrameWorkPath;
        public string UnityCorePath;
        public string EditorCorePath;
        public string UtilPath;
        public string EditorPath;


        public string FrameWorkName;
        public string Author;
        public string Version;
        public string Description;
    }
    [UnityEditor.CustomEditor(typeof(FrameworkConfigInfo))]
    class FrameworkConfigInfoEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            GUI.enabled = false;

            base.OnInspectorGUI();
        }

    }
}
