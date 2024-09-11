using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float fltDropWaitTime;
    private new MeshRenderer renderer;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= fltDropWaitTime)
        {
            Debug.Log("Time has been elapsed");
            //enable object's components
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
