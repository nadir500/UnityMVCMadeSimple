using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MoveCubeController moveCubeController = new MoveCubeController(); //alert controller of particular event 
        moveCubeController.MoveCube(this.gameObject); //do some event triggering controller 
    }
}
