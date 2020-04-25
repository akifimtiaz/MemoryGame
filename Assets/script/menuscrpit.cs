using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuscrpit : MonoBehaviour {
    public Canvas quiteMenu;
    public Button startText;
    public Button exitText;
	// Use this for initialization
	void Start ()
    {
        quiteMenu = quiteMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quiteMenu.enabled = false;
    }
	
	public void ExitPress()
    {
        quiteMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quiteMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("demo");
 
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
