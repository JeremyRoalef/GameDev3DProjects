using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    //float deltaTime = 0f;


    private void Start()
    {
        float timeToDestroy = GetComponent<ParticleSystem>().main.duration + 1f; //Gets the duration of the particle system. add a second so the whole system plays
        Destroy(gameObject, timeToDestroy); //destroy game object after the duration of the particle system has been played
    }

    //Original idea. Rick has better idea
    //private void Update()
    //{
    //    if (deltaTime > GetComponent<ParticleSystem>().main.duration)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        deltaTime += Time.deltaTime;
    //    }
}

