using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cactus")
        {
            CactusPower powerup = collision.gameObject.GetComponent<CactusPower>();
            powerup.ActivedCactusPower(powerup.powerUpTime);
        }
        return;
    }

}
