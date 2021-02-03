using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusPower : MonoBehaviour
{
    public float powerUpTime = 6;

    public void ActivedCactusPower(float timer)
    {
        Debug.Log("The player can kill Zombies for " + powerUpTime + " seconds!");
    }
}
