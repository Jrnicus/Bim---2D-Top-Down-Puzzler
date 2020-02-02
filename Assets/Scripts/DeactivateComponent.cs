using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateComponent : MonoBehaviour
{



    public void Activate(){

        if (!gameObject.activeInHierarchy){
            gameObject.SetActive(true);
        }

    }

    public void Deactivate(){

        if (gameObject.activeInHierarchy){
            gameObject.SetActive(false);
        }

    }
    

}
