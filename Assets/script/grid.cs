using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{


    public GameObject Cube;
    public int numberOfCubes = 12;
    public float distanceBwCube = 1.5f;
    public int cubesPerRow = 4;
    public List<string> ranamelist = new List<string>();
    public List<string> namelist = new List<string>();
    public static List<GameObject> cubelist = new List<GameObject>();


    void Start()
    {

        Instantiatee();
        //Instantiation();
        Randomise();
        foreach (string s in namelist)
        {
            print(namelist);
        }
        AssignName();
        CopyList();
        Randomise2();
        AssignName2();

    }

    void Instantiation()
    {

        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                GameObject cu = Instantiate(Cube, new Vector3(x, y, 0), Quaternion.identity);
                cubelist.Add(cu);
            }
        }
    }

    void Instantiatee()
    {
        float xoffset = 0.0f;
        float yoffset = 0.0f;

        for (int cc = 0; cc < numberOfCubes; cc++)
        {
            xoffset += distanceBwCube;
            if (cc % cubesPerRow == 0)
            {
                yoffset += distanceBwCube;
                xoffset = 0;
            }
            GameObject gb = Instantiate(Cube, new Vector3(transform.position.x + xoffset, transform.position.y + yoffset, transform.position.z), transform.rotation);
            cubelist.Add(gb);
        }
    }

    void Randomise()
    {
        for (int i = 0; i < namelist.Count; i++)
        {
            string temp = namelist[i];
            int randomIndex = Random.Range(i, namelist.Count);
            namelist[i] = namelist[randomIndex];
            namelist[randomIndex] = temp;
            
        }

    }

    void AssignName()
    {
        print(cubelist.Count);
        for (int b = 0; b < cubelist.Count / 2; b++)
        {
            cubelist[b].name = namelist[b];
            //print(rnamelist[b]); 
        }

    }
    void CopyList()
    {
        for (int g = 0; g < cubelist.Count / 2; g++)
        {
            ranamelist.Add(namelist[g]);
           // print(ranamelist[g]);
        }

    }


    void AssignName2()
    {
        int c = 0;
        for (int a = cubelist.Count / 2; a < cubelist.Count; a++)
        {
            cubelist[a].name = ranamelist[c];
            c++;
        }
    }
    void Randomise2()
    {
        for (int i = 0; i < cubelist.Count / 2; i++)
        {
            string temp = ranamelist[i];
            int randomIndex = Random.Range(i, ranamelist.Count);
            ranamelist[i] = ranamelist[randomIndex];
            ranamelist[randomIndex] = temp;
        }

    }



}







