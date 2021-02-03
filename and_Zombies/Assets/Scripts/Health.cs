using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health Value's")]
    [SerializeField] protected int maxHealth = 3;
    [SerializeField] protected int currentHealth;
    [Header("UI")]
    [SerializeField] private GameObject[] UI_Heart;

    public virtual void Start()
    {
        currentHealth = maxHealth;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DamagePlayer(1);
        }
    }
    public virtual void DamagePlayer(int damage)
    {

        currentHealth -= damage;
        UI_Heart[currentHealth].SetActive(false);
       
    }
    public virtual void ChangeHealth(int amount)
    {
        currentHealth = currentHealth + amount;
        Checkhealth();
    }

    protected virtual void Checkhealth()
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Kill();
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public virtual void Kill()
    {

    }
}
