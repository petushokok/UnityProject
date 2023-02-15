using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    bool isMenuOn = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
