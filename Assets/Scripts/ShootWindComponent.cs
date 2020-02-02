using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWindComponent : MonoBehaviour
{

    public Transform windTransform;

    public WindAnimator windAnimator;

    public void Awake(){
        windTransform.SetParent(null);
    }

    public void PositionWind(){

        windTransform.position = transform.position;
        
        Vector3 mousePosition = PlayerAimWeapon.GetMouseWorldPosition();

        // working on a 2d game, rotation works differently

        Vector3 aimDirection = (mousePosition - transform.position).normalized;

        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        windTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)){
            windAnimator.TriggerGust();
            PositionWind();
        }
    }
}
