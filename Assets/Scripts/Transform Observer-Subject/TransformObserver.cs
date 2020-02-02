using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformObserver : MonoBehaviour
{

    public List<TransformSubject> observedTransforms;


    public void Awake(){
        foreach(TransformSubject subject in observedTransforms){
            subject.Attach(this);
        }
    }


    public virtual void UpdateState(){
        Debug.Log("Updating State based on Observed Transforms");
    }

    
}

