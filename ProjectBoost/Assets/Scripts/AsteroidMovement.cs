using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 * The asteroid will move based on where it spawns. If it spawns on the left side of the gamespace, it will move to the right. If it moves
 * on the right side of the gamespace, it will move left. If it spawns above the gamespace, it will move down.
 * 
 * The asteroid will rotate based on a random number. Expected problem: rotating the object will cause the movement to act weird if using
 * relative velocity vectors. Potential solution: use real-world vector velocity.
 * 
 */
public class AsteroidMovement : MonoBehaviour
{
    //Cashe References
    Rigidbody asteroidRb;
    
    //Attributes
    Vector3 asteroidVelocity;
    Vector3 asteroidRotation;

    float fltMinRotation = 0.5f;
    float fltMaxRotation = 2.0f;

    void Start()
    {
        asteroidRb = GetComponent<Rigidbody>();
        InitializeAsteroid();
    }

    private void InitializeAsteroid()
    {
        //Set asteroid velocity

        //Debug.Log("Is the asteroidvelocity vector vector3.zero? " + asteroidVelocity);
        if (asteroidVelocity == Vector3.zero)
        {
            //Debug.Log("Set asteroid velocity to move");
            SetAsteroidVelocity(new Vector3(1, 1, 0));
            //Debug.Log("New asteroid velocity: " + asteroidVelocity);
        }

        //Set asteroid rotation Vector
        float fltXRotation = Random.Range(fltMinRotation, fltMaxRotation);
        float fltYRotation = Random.Range(fltMinRotation, fltMaxRotation);
        float fltZRotation = Random.Range(fltMinRotation, fltMaxRotation);
        asteroidRotation = new Vector3(fltXRotation, fltYRotation, fltZRotation) * Time.deltaTime;
    }

    void Update()
    {
        //rotate asteroid
        transform.Rotate(asteroidRotation);
    }


    //Method to set the velocity direction of the asteroid
    public void SetAsteroidVelocity(Vector3 velocityVector)
    {
        asteroidRb.velocity = velocityVector;
    }
}
