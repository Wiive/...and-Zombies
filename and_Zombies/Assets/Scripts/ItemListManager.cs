using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemListManager : MonoBehaviour
{
    [Header("Objective Lists")]
    [SerializeField] private TextMeshProUGUI[] ListText;
    [SerializeField]private bool[] ItemObtained;
    [Header("Win Screen")]
    [SerializeField] private GameObject winScreen;
    
    private void Start()
    {
        for (int i = 0; i < ListText.Length; i++)
        {
            ListText[i].color = Color.red;
        }
    }
    public virtual void ObjectObtained(int ItemIndex)
    {
        ListText[ItemIndex].color = Color.green;
        ItemObtained[ItemIndex] = true;
        WinCondition();
    }
    private void WinCondition()
    {
        if (ItemObtained[0] == true && 
            ItemObtained[1] == true && 
            ItemObtained[2] == true)
        {
            winScreen.SetActive(true);
        }
    }
}
