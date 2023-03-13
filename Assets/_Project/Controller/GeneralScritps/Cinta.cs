using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinta : MonoBehaviour
{
    public float moveSpeed = 1f;

    private void Start()
    {
        //moveSpeed *= 0.001f;
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.transform.CompareTag("Botella") || collision.transform.CompareTag("Servilleta") || collision.transform.CompareTag("Bateria") || collision.transform.CompareTag("Cascara"))
            {
            collision.transform.GetComponent<Rigidbody>().velocity = new Vector3(moveSpeed, 0f, 0f);
        }
    }
}
