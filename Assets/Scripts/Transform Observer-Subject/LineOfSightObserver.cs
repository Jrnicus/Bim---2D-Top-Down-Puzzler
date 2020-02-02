using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LineOfSightObserver : TransformObserver
{
    public bool SuccessIfHidden = false;

    public UnityEvent successfulUpdate;

    public override void UpdateState(){

        bool successfulUpdateState = false;

        bool allRaysHit = true;
        bool allRaysFailed = true;

        foreach(TransformSubject subject in observedTransforms){
            
        RaycastHit2D hit = Physics2D.Raycast(transform.position, subject.transform.position - transform.position);

            if (hit.collider != null){
                
                if (hit.collider.transform == subject.transform){
                    allRaysFailed = false;
                } else {
                    allRaysHit = false;
                }

            }
            // Do a raycast to all of the targets

            // if they all hit and SuccessIfHidden = false, set successfulUpdateState = true;
            if (allRaysFailed && SuccessIfHidden){
                successfulUpdateState = true;
            }
            // else if they all fail, and SuccessIfHidden = true, set successfulUpdateState = true;
            else if (allRaysHit && !SuccessIfHidden){
                successfulUpdateState = true;
            }

        }

        if (successfulUpdateState){
            successfulUpdate.Invoke();

            Debug.Log("Successful Transform Update Invoked");

        }

    }
}
