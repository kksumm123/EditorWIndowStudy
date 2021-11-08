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
    bool varDebugMode = false;
    void OnGUI()
    {

        GUILayout.BeginHorizontal();
        {
            GUILayout.Label("골드", GUILayout.MaxWidth(30));
            goldString = GUILayout.TextField(goldString, 10);
            if (GUILayout.Button("지급하기"))
            {
                int gold = Convert.ToInt32(goldString);
                if (gold > 0)
                {
                    GoldUI.instance.AddGold(gold);
                }
            }
        }
        GUILayout.EndHorizontal();

        varDebugMode = GUILayout.Toggle(varDebugMode, "디버그 모드");
        // varDebugMode 얘를 EditorPref 이용해서 저장하자.
        EditorPrefs.SetBool("디버그모드", varDebugMode);
    }
}