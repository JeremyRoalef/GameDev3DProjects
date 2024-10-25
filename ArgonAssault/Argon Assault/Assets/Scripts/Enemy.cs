using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject explsionVFX;
    [SerializeField] Transform parent;
    [SerializeField] int scoreValue;

    ScoreBoard scoreBoard;

    private void Awake()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>(); //find the first ohject with the scoreboard script
    }

    private void OnParticleCollision(GameObject other)
    {
        GameObject vfx = Instantiate(explsionVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parent;
        scoreBoard.UpdateScore(scoreValue);

        Destroy(gameObject);
    }

}
