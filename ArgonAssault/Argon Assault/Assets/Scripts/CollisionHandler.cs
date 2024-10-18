using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject explosionVFX;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision event.\nMain Object: " + this.gameObject + "\nOther Object: " + other.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {

        explosionVFX.SetActive(true);
        GetComponent<MeshRenderer>().enabled = false;
        
        StartCoroutine(StartDeathSequence());
    }

    IEnumerator StartDeathSequence()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
