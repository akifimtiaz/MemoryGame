using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
	public static bool isSelected = true;
	public static GameObject selected;
	public static GameObject unselected;
    public GameObject Cube;
    private static int count;
    public Text countText;
    public static bool isMoveBacked=true;
    public Text winText;
    public Text timeDisplay;
    public static float playedTime;
    public static int triesCount;
    
    void Start()
    {
        count = 10;
        winText.text = "";        
        SetCountText();
        playedTime = 0;
        triesCount = 0;
    }

    

    void Update()
    {
        
        SetCountText();
        SetTime();
        OnBack();
    }

    void OnBack()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("main_menu");
        }
    }


    public  static void Check()
    {
        if(cube.sIndex == cube.unIndex)
        {
            print("same");
            selected.gameObject.GetComponent<cube>().RotateBack();
            triesCount++;
        }
        else
        {
            if (selected.gameObject.name == unselected.gameObject.name)
            {
                // grid.cubelist.Remove(selected);
                //grid.cubelist.Remove(unselected);
                
                unselected.gameObject.GetComponent<cube>().enabled = false;
                selected.gameObject.GetComponent<cube>().enabled= false;
                count--;
                
                Destroy(selected);
                Destroy(unselected);
                grid.cubelist.Remove(selected);
                grid.cubelist.Remove(unselected);

                controller.isMoveBacked = true;
                print(count);
                triesCount++;
            }
            else
            {
                unselected.gameObject.GetComponent<cube>().RotateBack();
                selected.gameObject.GetComponent<cube>().RotateBack();
                triesCount++;
            }
        }
    }

    void SetCountText()
    {
        countText.text = "M a t c h e s  L e f t : " + count.ToString();
        if (count <= 0)
        {
            SceneManager.LoadScene("win");
            countText.enabled = false;
            
        }
    }

    public void SetTime()
    {
        playedTime += Time.deltaTime;
       // playedTime = Mathf.Round(playedTime ) ;
        timeDisplay.text = "TimE :  " + playedTime.ToString("F0")+("                      ");
    }
    

    public static void ActivateCube()
    {
        foreach (GameObject g in grid.cubelist) {

            g.GetComponent<cube>().enabled = true;
        }
    }

    
}
