using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawwer : MonoBehaviour {

    // Use this for initialization
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float highet;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(timer > maxTime)
        {

            GameObject newPipe= Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-highet, highet), 0);
            Destroy(newPipe, 5);
            timer = 0;
        }

        timer += Time.deltaTime;
		
	}
}
