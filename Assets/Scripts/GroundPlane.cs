using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlane : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "plane")
        {
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject);
        }
    }
}
