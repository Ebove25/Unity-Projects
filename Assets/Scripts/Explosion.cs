using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 particleSpawnPoint = other.transform.position;
        Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);

        //Destroy() is the best function for destroying components and objects in a scene
        //You need to specify that you are referring to a game object
        //Destroy(this), for instance, will destroy the script, not the object.
        //Destroy(this.gameObject) will destroy the object where this component is
        Destroy(other.gameObject);
    }
}
