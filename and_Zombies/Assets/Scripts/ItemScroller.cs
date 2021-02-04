using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScroller : MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 60);
    }
    private void border()
    {
        if (this.transform.position.x <= -960)
        {
            Destroy(this.gameObject);
        }
    }
}
