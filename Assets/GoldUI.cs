using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        gold += addValue;
        Refresh();
    }

    private void Refresh()
    {
        goldValue.text = gold.ToString();
    }

}
