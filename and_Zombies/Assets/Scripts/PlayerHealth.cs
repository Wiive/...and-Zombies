using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ChangeHealth(int amount)
    {
        base.ChangeHealth(amount);
    }

    protected override void Checkhealth()
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Kill();

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }

    public override void Kill()
    {
        base.Kill();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            print("Collision");
            DamagePlayer(1);
        }
    }

    public float GetMaxHealth()
    {
        return maxHealth;
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }
}
