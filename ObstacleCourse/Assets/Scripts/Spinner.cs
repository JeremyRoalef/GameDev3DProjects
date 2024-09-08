using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float fltRotateSpeed;
    [SerializeField] float fltSpinDelay;
    [SerializeField] int intNumberOfBlades;
    [SerializeField] GameObject bladePrefab;
    [SerializeField] int intSpinDirection;
    bool boolIsRotating = false;


    // Update is called once per frame
    void Update()
    {
        if (!boolIsRotating)
        {
            StartCoroutine(RotateObject());
        }
    }

    //Create coroutine to cause obejct to rotate
    IEnumerator RotateObject()
    {
        int intRotateAmount = 180 / intNumberOfBlades;

        boolIsRotating = true;
        // Calculate the target rotation
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = startRotation * Quaternion.Euler(0, intRotateAmount * intSpinDirection, 0);

        while (Quaternion.Angle(transform.rotation, endRotation) > 0.01f) //calculates the angle between two rotations
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, endRotation, fltRotateSpeed * Time.deltaTime);
            yield return null; // Wait for the next frame

        }
        transform.rotation = endRotation;

        yield return new WaitForSeconds(fltSpinDelay);

        boolIsRotating = false;
    }

    //Create public method for use by bladeManagerEditor script
    public void CreateBlades()
    {
        //Loop through all the children in the parent object and immediately destroy them
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject); //DestroyImmediate used when using unity editor
        }

        //Rotation of each blade is dependent on 180 / the number of blade
        float fltBladeRotationIncrement = 180f / intNumberOfBlades;

        //Add new blades
        for (int i = 0; i < intNumberOfBlades; i++)
        {
            Quaternion bladeRoation = Quaternion.Euler(0,fltBladeRotationIncrement*i,0);

            GameObject newBlade = Instantiate(bladePrefab, transform.position, bladeRoation);

            //Give blade object a name
            newBlade.name = "Blade(" + (i+1) + ")";

            //Set its parent object to object the script is on
            newBlade.transform.SetParent(transform);
            //Set its scale to parent object's scale

        }
    }
}
