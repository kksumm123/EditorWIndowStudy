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
        GetWindow(typeof(MyTool));
    }
    string goldString = "";
    void OnGUI()
    {
        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("���");
            goldString = GUILayout.TextField(goldString, 10);
            if (GUILayout.Button("�����ϱ�"))
            {
                int gold = Convert.ToInt32(goldString);
                if (gold > 0)
                {
                    GoldUI.instance.AddGold(gold);
                }
            }
        }
        GUILayout.EndHorizontal();
    }
}
