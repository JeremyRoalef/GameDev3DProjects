using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fltHorizontalMovement = Input.GetAxis("Horizontal"); //horizontal is the axis name
        Debug.Log(fltHorizontalMovement);

        float fltVerticalMovement = Input.GetAxis("Vertical"); //Vertical is the axis name
        Debug.Log(fltVerticalMovement);
    }
}
