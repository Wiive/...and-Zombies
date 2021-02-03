using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemListManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] ListText;
    private bool[] ItemObtained;

    private void Start()
    {
        for (int i = 0; i < ListText.Length; i++)
        {
            ListText[i].color = Color.red;
        }
    }
    private void Update()
    {
        WinCondition();
    }
    public virtual void ObjectObtained(int ItemIndex)
    {
        ListText[ItemIndex].color = Color.green;
        ItemObtained[ItemIndex] = true;
    }
    private void WinCondition()
    {
        if (ItemObtained[0] == true && ItemObtained[1] == true && ItemObtained[2] == true)
        {
            Debug.Log("You Won");
        }
    }
}
