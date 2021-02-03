using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    void Update()
    {
        border();
        transform.Translate(Vector3.left * Time.deltaTime * 60);
    }
    private void border()
    {
        if (this.transform.position.x <= -960)
        {
            this.transform.position = new Vector3(320, 180, 10);
        }
    }
}
