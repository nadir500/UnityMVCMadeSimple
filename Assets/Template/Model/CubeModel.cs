using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModel
{
    public string name { get; set; }
    public GameObject cubeGameObject { get; set; }  //reference from scene view 

    public CubeModel() //default constructor 
    {
        name = "";
        this.cubeGameObject = null;
    }
    public CubeModel(string cubeName , GameObject cubeGameObject)
    {
        this.name = cubeName;
        this.cubeGameObject = cubeGameObject;
        Debug.Log("Alert Model Updated with New Info");
    }

}
