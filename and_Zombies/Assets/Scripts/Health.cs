using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private PlayerHealth playerHealth;

    [SerializeField] protected float maxHealth = 3;
    [SerializeField] protected float currentHealth;

    public virtual void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }

    public virtual void ChangeHealth(float amount)
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
