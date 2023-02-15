using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    public TMP_Text scoreText;
    public GameObject win;
    public GameObject menu;
    bool isMenuOn = false;
    void Start()
    {
        score = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (score >= 5)
        {
            win.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && isMenuOn == false)
        {
            menu.SetActive(true);
            isMenuOn = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isMenuOn == true)
        {
            menu.SetActive(false);
            isMenuOn = false;
        }
    }
    public void RESTART()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    
}
