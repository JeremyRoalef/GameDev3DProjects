using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] ParticleSystem playerDeath;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            //instantiate particle system
            Instantiate(playerDeath, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
