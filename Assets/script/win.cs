using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour {
    public Text time;
    public Text tries;
    public Button replay;
    
	void Start ()
    {
        SetTriesCount();
        GetTime();
    }

    public void setReplay()
    {

        SceneManager.LoadScene("main_menu");
    }

    public void SetTriesCount()
    {
        tries.text = "tries : " + controller.triesCount.ToString();     
    }

    public void GetTime()
    {
        time.text = "time    : " + controller.playedTime.ToString("F2");
    }

}
