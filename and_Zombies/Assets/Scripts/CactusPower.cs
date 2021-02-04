using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusPower : MonoBehaviour
{
    public float powerUpTime = 6;
    bool pickedUp = false;

    public void ActivedCactusPower(float timer)
    {
        Debug.Log("The player can kill Zombies for " + powerUpTime + " seconds!");
        this.pickedUp = true;
    }

    private void Update()
    {
        if (!pickedUp)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 60);
        }

        if (this.transform.position.x <= -960)
        {
            Destroy(gameObject);
        }
    }
}
