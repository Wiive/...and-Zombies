using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    public bool hasCactusPower = false;
    private float timer;
    Transform cactus;

    private void Update()
    {
        if (hasCactusPower)
        {
            if (timer > 0)
            {
                cactus.parent = gameObject.transform;                               //Make the cactus follows the player until the CactusPower sctips power timer is out
                timer -= 1 * Time.deltaTime;
            }
            else
            {
                hasCactusPower = false;
            }
        }
        else
        {
            if (cactus != null)
            {
                Destroy(cactus.gameObject);                                         //Destroys the cactus
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cactus")
        {
            cactus = collision.transform;                                           //Setting the cactus as an transform referenst
            CactusPower powerup = collision.gameObject.GetComponent<CactusPower>(); //Getting acces to the powerup fuctions
            powerup.ActivedCactusPower(powerup.powerUpTime);                        
            timer = powerup.powerUpTime;                                            //Setting the players powerup timer to the cactus timer
            hasCactusPower = true;
        }
        return;
    }

    public bool CactusPower()
    {
        return hasCactusPower;                                                      //Returning if the player has the Cactuspower up or not
    }
}
