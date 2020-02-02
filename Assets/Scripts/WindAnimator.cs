using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WindAnimator : MonoBehaviour
{

    [SerializeField]
    private Animator windGust;

    public void TriggerGust(){
        windGust.SetTrigger("Wind");
    }

    
}
