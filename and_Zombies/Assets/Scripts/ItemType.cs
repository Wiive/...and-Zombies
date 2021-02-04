using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemType : MonoBehaviour
{
    [SerializeField] private int itemID;
    [SerializeField] private Sprite[] ItemSprite = new Sprite[3];
    private SpriteRenderer spriteRenderer;

    [SerializeField]private ItemListManager ItemManager;
    private GameObject Manager;

    private void Awake()
    {
        Load();
    }
    public void Load()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Manager = GameObject.FindGameObjectWithTag("Manager");
        ItemManager = Manager.GetComponent<ItemListManager>();
    }
    private void Start()
    {
        Load();
        itemID = Random.Range(0, 3);
        if (itemID == 3)
        {
            itemID = 2;
        }
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
