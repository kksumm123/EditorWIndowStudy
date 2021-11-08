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
        // ����� üũ�ڽ��� üũ �Ǿ����� ���� ��ġ��ȭ�� ��������
#if UNITY_EDITOR
        if (EditorPrefs.GetBool("����׸��"))
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
