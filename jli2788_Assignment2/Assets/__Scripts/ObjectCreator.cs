using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject cubePrefabVar;
    private GameObject cube;
    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;
    private GameObject cube4;
    private GameObject cube5;
    private GameObject cube6;
    private GameObject cube7;
    private GameObject cube8;


    void Start()
    {

        cubePrefabVar.tag = "Pick Up";
        cubePrefabVar.GetComponent<Collider>().isTrigger = true;


        cube = Instantiate(cubePrefabVar, new Vector3(4.77f, 1.76f, -2.01f), Quaternion.Euler(-10.25f, -21.25f, -8.7f));
        cube.GetComponent<Renderer>().material.color = Color.white;
       

        cube1 = Instantiate(cubePrefabVar, new Vector3(-3.92f, 1.7f, -3.17f), Quaternion.Euler(-27.72f, -58.83f, 9.83f));
        cube1.GetComponent<Renderer>().material.color = Color.yellow;

        cube2 = Instantiate(cubePrefabVar, new Vector3(-2.38f, 1.7f, -6.28f), Quaternion.Euler(-53f, -117.35f, 38.26f));
        cube2.GetComponent<Renderer>().material.color = Color.cyan;

        cube3 = Instantiate(cubePrefabVar, new Vector3(0.97f, 1.53f, -5.52f), Quaternion.Euler(0.228f, -156.84f, 90.455f));
        cube3.GetComponent<Renderer>().material.color = Color.white;

        cube4 = Instantiate(cubePrefabVar, new Vector3(-1.77f, 1.7f, 2.66f), Quaternion.Euler(19.28f, -25.83f, -9f));
        cube4.GetComponent<Renderer>().material.color = Color.yellow;
        
        cube5 = Instantiate(cubePrefabVar, new Vector3(4.38f, 1.8f, 1.55f), Quaternion.Euler(-10.25f, -21.25f, -8.7f));
        cube5.GetComponent<Renderer>().material.color = Color.cyan;

        cube6 = Instantiate(cubePrefabVar, new Vector3(-4.29f, 1.7f, 0.57f), Quaternion.Euler(36.46f, -29.2f, -10.67f));
        cube6.GetComponent<Renderer>().material.color = Color.white;

        cube7 = Instantiate(cubePrefabVar, new Vector3(4.1f, 1.7f, -5.35f), Quaternion.Euler(-48.84f, -37.34f, 5.29f));
        cube7.GetComponent<Renderer>().material.color = Color.yellow;

        cube8 = Instantiate(cubePrefabVar, new Vector3(1.67f, 1.8f, 2.69f), Quaternion.Euler(-10.25f, -21.25f, -8.7f));
        cube8.GetComponent<Renderer>().material.color = Color.cyan;

                

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



