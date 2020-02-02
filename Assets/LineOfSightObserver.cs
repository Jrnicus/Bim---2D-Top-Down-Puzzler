using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LineOfSightObserver : TransformObserver
{
    public bool SuccessIfHidden = false;

    public UnityEvent successfulUpdate;

    public override void UpdateState(){

        foreach(TransformSubject subject in observedTransforms){
            
            // Do a raycast to all of the targets

            // if they all hit and SuccessIfHidden = false, InvokeSuccessfulUpdate
        
            // else if they all fail, and SuccessIfHidden = true, InvokeSuccessfulUpdate

        }

    }
}
