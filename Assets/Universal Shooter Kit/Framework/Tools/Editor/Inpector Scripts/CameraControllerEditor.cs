﻿using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace GercStudio.USK.Scripts
{

	[CustomEditor(typeof(CameraController))]
	public class CameraControllerEditor : Editor
	{
		public CameraController script;

		public void Awake()
		{
			script = (CameraController) target;
		}
        
		public override void OnInspectorGUI()
		{
			serializedObject.Update();
			
			EditorGUILayout.HelpBox("You can adjust camera settings in the [Controller] script that is on your character prefab.", MessageType.Info);

			serializedObject.ApplyModifiedProperties();

			// DrawDefaultInspector();
			
		}
	}
}
