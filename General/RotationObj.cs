using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj : MonoBehaviour
{
    //control var
    public int rotateSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        // rotation on certain axis and using space.world for making entire script and rotation relative to world around it
        transform.Rotate(0, rotateSpeed, 0, Space.World);
        
    }
}
