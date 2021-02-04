using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemListManager : MonoBehaviour
{
    [Header("Objective Lists")]
    [SerializeField] private Image[] ObjectSprite;
    [SerializeField]private bool[] ItemObtained;
    [Header("Win Screen")]
    [SerializeField] private GameObject winScreen;
    
    private void Start()
    {
        for (int i = 0; i < ObjectSprite.Length; i++)
        {
            ObjectSprite[i].color = Color.grey;
        }
    }
    public virtual void ObjectObtained(int ItemIndex)
    {
        ObjectSprite[ItemIndex].color = Color.white;
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
