using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MyTool : EditorWindow
{

    [MenuItem("Tools/MyTool")]
    static void MyMenu()
    {
        Debug.Log("나 불려써?");
        GetWindow(typeof(MyTool));
    }
    string goldString;
    void OnGUI()
    {
        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("골드\b\b");
            goldString = GUILayout.TextField(goldString, 10);
            if (GUILayout.Button("지급하기"))
            {
                Debug.Log($"{goldString} 골드 주까?");
            }
        }
        GUILayout.EndHorizontal();
    }
}
