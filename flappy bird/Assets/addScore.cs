using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour {

    public AudioSource scoore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoore.Play();
        score.Score++;
    }
}
