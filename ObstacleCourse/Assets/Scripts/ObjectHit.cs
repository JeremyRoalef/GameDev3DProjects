using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Wall has been hit");

        //get the component of the object and change its color
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red; //Change the meshrenderer's material color to red.
            gameObject.tag = "Hit";
        }
        
    }
}
