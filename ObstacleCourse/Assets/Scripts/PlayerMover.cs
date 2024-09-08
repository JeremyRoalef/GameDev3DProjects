using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float fltYSpeed;
    [SerializeField] float fltYRotation;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer()
    {
        float fltZValue = Input.GetAxis("Vertical") * Time.deltaTime * fltYSpeed; //'Time.deltaTime' removes fps requirements for movement in game
        transform.Translate(0, 0, fltZValue);
    }
    void RotatePlayer()
    {
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = transform.rotation * Quaternion.Euler(0, Input.GetAxis("Horizontal") * Time.deltaTime * fltYRotation, 0);
        transform.rotation = Quaternion.RotateTowards(startRotation, endRotation, 10f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EndLocation")
        {
            LoadNextScene();
        }
    }
    private void LoadNextScene()
    {
        int intNextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(intNextSceneIndex);
    }

}
