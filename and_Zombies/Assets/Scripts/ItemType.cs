using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemType : MonoBehaviour
{
    [SerializeField] private int itemID;

    private ItemListManager ItemManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ItemManager.ObjectObtained(itemID);
        }
    }
}
