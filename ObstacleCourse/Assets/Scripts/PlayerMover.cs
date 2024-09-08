using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float fltXSpeed;
    [SerializeField] float fltYSpeed;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructionsToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float fltXValue = Input.GetAxis("Horizontal") * Time.deltaTime * fltXSpeed; //'a' 'd' 'left' and 'right' keys assign value to variable
        float fltZValue = Input.GetAxis("Vertical") * Time.deltaTime * fltYSpeed; //'Time.deltaTime' removes fps requirements for movement in game
        transform.Translate(fltXValue, 0, fltZValue);
    }

    void PrintInstructionsToConsole()
    {
        Debug.Log("Game Started. W and S to move up and down. A and D to move left and right");
    }
}
