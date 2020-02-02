using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSubject : MonoBehaviour
{

    public List<TransformObserver> observedBy;

    public void Attach(TransformObserver observer){
        observedBy.Add(observer);
    }

    public void UpdateObservers(){
        foreach(TransformObserver observer in observedBy) {
            observer.UpdateState();
        }
    }



}
