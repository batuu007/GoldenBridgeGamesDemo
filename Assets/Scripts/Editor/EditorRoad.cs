using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class EditorRoad : EditorWindow
{
    private float zValue;
    private int count;

    GameObject parent;

    [MenuItem("Window/RoadEditor")]

    public static void ShowWindow()
    {
        GetWindow<EditorRoad>("RoadEditor");
    }

    private void OnGUI()
    {
        GUILayout.Label("Create From Selected Object :", EditorStyles.boldLabel);
        GUILayout.Label("Z Value :", EditorStyles.boldLabel);
        zValue = EditorGUILayout.FloatField(zValue);
        GUILayout.Label("Count :", EditorStyles.boldLabel);
        count = EditorGUILayout.IntField(count);
        parent = GameObject.FindGameObjectWithTag("Highway");

        if (GUILayout.Button("Create"))
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                for (int i = 0; i < count; i++)
                {
                    GameObject g = Instantiate(obj);
                    Vector3 pos = obj.transform.position;
                    pos.z += zValue * (i + 1);
                    g.transform.position = pos;
                    g.transform.SetParent(parent.transform);
                } 
            }
        }
    }
}
