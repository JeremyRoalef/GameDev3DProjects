using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //get the new input system

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction movement; //sf for input action
    [SerializeField] InputAction fire; //sf for firing
    [SerializeField] float fltMoveSpeed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable() //this method is called after awake and before start. Called in the initialization order of events.
    {
        movement.Enable(); //enable the movement input action
    }

    private void OnDisable()
    {
        movement.Disable(); //disable the movement inputaction when not being used.
    }

    // Update is called once per frame
    void Update()
    {
        //using new input system

        /*
         * The new input system takes advantage of not needing strings to determine the type of input written. In unity editor, you choose the type of
         * input binding you want for the designed variable & those will be stored as vectors. The movement binding is reading a, d, w, and s for input
         * and storing the positive/negative value of right/left in d/a and up/down value in w/s.
         */


        float fltHorizontalMovement = movement.ReadValue<Vector2>().x; //read the vector2 value attached to movement InputAction as set up in unity editor
        float fltVerticalMovement = movement.ReadValue<Vector2>().y;

        float fltXOffset = fltHorizontalMovement * fltMoveSpeed;
        float fltYOffset = fltVerticalMovement * fltMoveSpeed;

        transform.localPosition = new Vector3(
            transform.localPosition.x + fltXOffset, 
            transform.localPosition.y + fltYOffset, 
            transform.localPosition.z);
    }
}
