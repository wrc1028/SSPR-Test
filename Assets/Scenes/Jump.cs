using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private void FixedUpdate() 
    {
        transform.Rotate(new Vector3(0, 5.0f, 0));
    }
}
