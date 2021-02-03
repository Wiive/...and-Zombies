using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusPower : MonoBehaviour
{
    [SerializeField] float powerUpTime = 6;

    public void ActivedCactusPower()
    {
        Debug.Log("The player can kill Zombies for " + powerUpTime + " seconds!");
    }
}
