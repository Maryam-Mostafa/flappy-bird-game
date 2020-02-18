using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

   public GameObject gameOverCanvas;

    void Start()
    {
        Time.timeScale = 1;
    }
    public void gameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }


}
