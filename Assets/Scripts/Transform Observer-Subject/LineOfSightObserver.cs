using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LineOfSightObserver : TransformObserver
{

    public LayerMask LightQuery;

    public bool SuccessIfHidden = false;

    public UnityEvent successfulUpdate;

    public override void UpdateState(){

        bool successfulUpdateState = false;

        int raysHit = 0;
        int raysFailed = 0;
        

        for(int i = 0; i < observedTransforms.Count; i++){
            
            RaycastHit2D hit = Physics2D.Raycast(transform.position, observedTransforms[i].transform.position - transform.position, 100f, LightQuery);

                if (hit.collider != null){
                    
                    if (hit.collider.transform.Equals(observedTransforms[i].transform)){
                        raysHit++;
                    } else {
                        raysFailed++;
                    }
                    

                } 
            // Do a raycast to all of the targets         

        }

        // if they all hit and SuccessIfHidden = false, set successfulUpdateState = true;
            if (raysHit == observedTransforms.Count && SuccessIfHidden){
                successfulUpdateState = true;
                Debug.Log("Successful Rays == ObservedTransforms.Count");
            }
            // else if they all fail, and SuccessIfHidden = true, set successfulUpdateState = true;
            else if (raysFailed == observedTransforms.Count && !SuccessIfHidden){
                successfulUpdateState = true;
                Debug.Log("Failed Rays: " + raysFailed + " == ObservedTransforms.count: " + observedTransforms.Count);
            }

        if (successfulUpdateState){
            successfulUpdate.Invoke();

            Debug.Log("Successful Transform Update Invoked");

        }

    }
}
