using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject DeathFX;
    [SerializeField] GameObject hitVFX;
    [SerializeField] int scoreValue;
    [SerializeField] int intHp;
    [SerializeField] int intDamageToTake;

    ScoreBoard scoreBoard;
    GameObject parentGameObject;

    private void Awake()
    {

        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
        intHp = 100;
        scoreBoard = FindObjectOfType<ScoreBoard>(); //find the first ohject with the scoreboard script
    }

    private void Start()
    {
        parentGameObject = GameObject.FindGameObjectWithTag("SpawnAtRuntime");
    }

    private void OnParticleCollision(GameObject other)
    {

        intHp -= intDamageToTake;

        if (intHp <= 0)
        {
            GameObject vfx = Instantiate(DeathFX, transform.position, Quaternion.identity);
            vfx.transform.parent = parentGameObject.transform;
            Destroy(gameObject);
            scoreBoard.UpdateScore(scoreValue);
        }
        else
        {
            GameObject vfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
            vfx.transform.parent = parentGameObject.transform;
        }
    }

}
