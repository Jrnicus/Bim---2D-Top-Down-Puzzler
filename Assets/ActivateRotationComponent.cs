using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRotationComponent : MonoBehaviour, IWindable
{

    public float turnsPerCircle = 6;

    public void Wind(Vector2 direction)
    {
        Rotate();
    }

    public void Rotate()
    {
        int degrees = (int)(360 / turnsPerCircle);

        Debug.Log("Current Rotation:" + transform.rotation.z + "Degrees: " + degrees + " = " + transform.rotation.z + degrees);

        Debug.Log(degrees);
        transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, (int)transform.rotation.z + degrees));
        
    }

}
