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
        Debug.Log("�� �ҷ���?");
        GetWindow(typeof(MyTool));
    }
    string goldString;
    void OnGUI()
    {
        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("���\b\b");
            goldString = GUILayout.TextField(goldString, 10);
            if (GUILayout.Button("�����ϱ�"))
            {
                Debug.Log($"{goldString} ��� �ֱ�?");
            }
        }
        GUILayout.EndHorizontal();
    }
}
