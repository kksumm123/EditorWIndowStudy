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
    string goldString = "";
    void OnGUI()
    {
        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("골드\b\b");
            goldString = GUILayout.TextField(goldString, 10);
            if (GUILayout.Button("지급하기"))
            {
                int gold = Convert.ToInt32(goldString);
                if (gold > 0)
                {
                    Debug.Log($"{gold} 골드 주께");

                }
            }
        }
        GUILayout.EndHorizontal();
    }
}
