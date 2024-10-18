using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision event.\nMain Object: " + this.gameObject + "\nOther Object: " + other.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Debug.Log("Trigger event.\nMain Object: " + this.gameObject + "\nOther Object: " + other.gameObject);
    }
}
