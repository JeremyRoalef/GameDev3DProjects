using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int intObjectsHit = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            intObjectsHit++;
            Debug.Log("Objects hit: " + intObjectsHit);
        }
    }
}
