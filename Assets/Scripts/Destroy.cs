using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DestroyArea")
        {

            Destroy(this.gameObject);
            Debug.Log("Ž€");
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
