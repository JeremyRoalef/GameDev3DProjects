using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject explsionVFX;
    [SerializeField] Transform parent;
    [SerializeField] GameObject hitVFX;
    [SerializeField] int scoreValue;
    [SerializeField] int intHp;
    [SerializeField] int intDamageToTake;

    ScoreBoard scoreBoard;

    private void Awake()
    {

        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;

        intHp = 100;
        scoreBoard = FindObjectOfType<ScoreBoard>(); //find the first ohject with the scoreboard script
    }

    private void OnParticleCollision(GameObject other)
    {

        intHp -= intDamageToTake;

        if (intHp <= 0)
        {
            GameObject vfx = Instantiate(explsionVFX, transform.position, Quaternion.identity);
            vfx.transform.parent = parent;
            Destroy(gameObject);
            scoreBoard.UpdateScore(scoreValue);
        }
        else
        {
            GameObject vfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
            vfx.transform.parent = parent;
        }
    }

}
