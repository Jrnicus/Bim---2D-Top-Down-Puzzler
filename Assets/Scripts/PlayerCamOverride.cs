using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine; 

public class PlayerCamOverride : MonoBehaviour
{

    public CinemachineVirtualCamera camera;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SetCamPriority(11);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DeprioritizeCamera();
        }
    }

    public void DeprioritizeCamera()
    {
        SetCamPriority(9);
    }

    public void SetCamPriority(int priority)
    {
        camera.Priority = priority;
    }



}
