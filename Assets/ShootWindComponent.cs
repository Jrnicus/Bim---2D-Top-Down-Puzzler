using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWindComponent : MonoBehaviour
{

    public WindAnimator windAnimator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            windAnimator.TriggerGust();
        }
    }
}
