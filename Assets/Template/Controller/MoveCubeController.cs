using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeController  
{
   public void MoveCube(GameObject cubeGameObject)
    {
       CubeModel cubeModel = new CubeModel("ModelCube", cubeGameObject);  //grabs model data and update it  
        cubeModel.cubeGameObject.transform.position = new Vector3(4,4,4);
    }
}
