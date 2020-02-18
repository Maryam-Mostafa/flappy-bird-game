using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class score : MonoBehaviour {

    // Use this for initialization
    public static int Score = 0;
    void Start () {
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<UnityEngine.UI.Text>().text = Score.ToString();
	}
}
