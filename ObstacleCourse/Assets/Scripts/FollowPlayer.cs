using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    CinemachineVirtualCamera cinemachineVirtualCamera;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        cinemachineVirtualCamera.LookAt = player.transform;
        cinemachineVirtualCamera.Follow = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
