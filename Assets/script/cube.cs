using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cube : MonoBehaviour {

    public GameObject cardBack;
    public float rotationspeed = 70f;
    public float brotationspeed = -90f;
    public static int sIndex;
    public static int unIndex;

    public bool brot = false;
    private Vector3 currentAngle;


    void Start()
    {

    }

    void Update()
    {
     
    }

    

    void OnMouseDown()
    {
        
        if(controller.isMoveBacked==true)
     
        {
            if (controller.isSelected == true)
            {
                sIndex = grid.cubelist.FindIndex(d => d == this.gameObject);
                controller.selected = this.gameObject;
                controller.isSelected = false;
                //iTween.RotateTo(gameObject, iTween.Hash("rotation", new Vector3(0, 180, 0), "easeType", "linear", "time", .8f, "oncomplete", "done"));
                transform.DORotate(new Vector3(0, 180, 0), 0.8f);
            }
            else
            {
                controller.unselected = this.gameObject;
               //controller.DeactivateCube();
                unIndex = grid.cubelist.FindIndex(d => d == this.gameObject);
                controller.isSelected = true;
                //iTween.RotateTo(gameObject, iTween.Hash("rotation", new Vector3(0, 180, 0), "easeType", "linear", "time", .8f, "oncomplete", "done2"));
                transform.DORotate(new Vector3(0, 180, 0), 0.8f).OnComplete(done2);
                controller.isMoveBacked = false;
            }
            ChangeTexture();
        }
    }

    public  void RotateBack()
    {
        //iTween.RotateTo(gameObject, iTween.Hash("rotation", new Vector3(0, 0, 0), "easeType", "linear", "delay",.1f, "oncomplete", "rotatedBackCompleted"));
        transform.DORotate(new Vector3(0, 0, 0), 1).SetEase(Ease.Linear).SetDelay(0.5f).OnComplete(rotatedBackCompleted);
    }

   
    void done2()
    {
      controller.Check();
    }
    void rotatedBackCompleted() {

        controller.isMoveBacked = true;
    }
    void ChangeTexture()
    {
        if (this.gameObject.name == "Apple")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Apple");
            cardBack.GetComponent<SpriteRenderer>().sprite= t;
        }

        if (this.gameObject.name == "Mango")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Mango");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }

        if (this.gameObject.name == "Peach")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Peach");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "Orange")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Orange");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "Grapes")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Grapes");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "Banana")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Banana");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "Stawberry")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Stawberry");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "Guava")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Guava");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "Watermelon")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Watermelon");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "Pomegrante")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("Pomegrante");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }

        if (this.gameObject.name == "5")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("5");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "8")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("8");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "11")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("11");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "12")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("12");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "15")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("15");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
        }
        if (this.gameObject.name == "1")
        {
            Sprite t = (Sprite)Resources.Load<Sprite>("1");
            cardBack.GetComponent<SpriteRenderer>().sprite = t;
            //Texture t = (Texture)Resources.Load<Texture>("1");
            /* Renderer[] renderChildren = this.gameObject.GetComponentsInChildren<Renderer>();
            renderChildren[3].material.mainTexture = t;
            renderChildren[4].material.mainTexture = t;*/
        }
    }
}
