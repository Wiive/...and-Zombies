using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemType : MonoBehaviour
{
    [SerializeField] private int itemID;
    [SerializeField] private Sprite[] ItemSprite = new Sprite[3];
    private SpriteRenderer spriteRenderer;

    [SerializeField]private ItemListManager ItemManager;

    private void Start()
    {
        itemID = Random.Range(0, 2);
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (itemID == 0)
        {
            spriteRenderer.sprite = ItemSprite[0];
        }
        if (itemID == 1)
        {
            spriteRenderer.sprite = ItemSprite[1];
        }
        if(itemID == 2)
        {
            spriteRenderer.sprite = ItemSprite[2];
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ItemManager.ObjectObtained(itemID);
            gameObject.SetActive(false);
        }
    }
}
