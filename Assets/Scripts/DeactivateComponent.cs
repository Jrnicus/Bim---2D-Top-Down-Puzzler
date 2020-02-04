using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeactivateComponent : MonoBehaviour // this could be an interface, Deactivateable and Activatable, or IToggleable
{

    public UnityEvent OnActivation;
    public UnityEvent OnDeactivation;

    public void Activate(){

        if (!gameObject.activeInHierarchy){
            gameObject.SetActive(true);
            OnActivation.Invoke();
        }

    }

    public void Deactivate(){

        if (gameObject.activeInHierarchy){
            OnDeactivation.Invoke();
            gameObject.SetActive(false);
        }

    }
    

}
