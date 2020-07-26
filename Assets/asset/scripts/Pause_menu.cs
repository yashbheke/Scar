using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public static bool pause= false;
    public GameObject pauseMenu;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           if(pause){
              Resume();  
		   }
           else{
              Paused();  
		   }
		}
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale= 1f;
        pause= false;
	}

    void Paused(){
        pauseMenu.SetActive(true);
        Time.timeScale= 0f;
        pause= true;
	}

    public void load_menu(){
        SceneManager.LoadScene("UI");
	}

    public void Quitgame(){
        Application.Quit();
	}
}
