using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyLittleBird : MonoBehaviour {

    // Use this for initialization
    public float velocity = 1;
    private Rigidbody2D rb;
    public gameManager gm;
    public AudioSource fly;
    public AudioSource die;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        GameObject.Find("gameOverCanvas").SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            fly.Play();
            rb.velocity = Vector2.up * velocity;
        }
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        die.Play();
        gm.gameOver();

    }
}
