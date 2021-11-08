using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GoldUI : MonoBehaviour
{
    public static GoldUI instance = null;
    private void Awake() => instance = this;

    int gold;
    Text goldValue;
    void Start()
    {
        goldValue = transform.Find("Value").GetComponent<Text>();
        Refresh();
    }

    public void AddGold(int addValue)
    {
        // 디버그 체크박스가 체크 되어있을 때만 수치변화를 보여주자
#if UNITY_EDITOR
        if (EditorPrefs.GetBool("디버그모드"))
            print($"{gold} -> {gold + addValue}");
#endif

        gold += addValue;
        Refresh();
    }

    private void Refresh()
    {
        goldValue.text = gold.ToString();
    }
}
