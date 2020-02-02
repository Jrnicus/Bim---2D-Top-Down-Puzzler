using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSystem : MonoBehaviour
{

public Vector3 startPos;
public Vector3 endPos;

public LayerMask interactables;


public void Update(){


    if (Input.GetMouseButtonDown(0)){
        MouseDown();
    } else if (Input.GetMouseButtonUp(0)){
        MouseUp();
    }

}

    void MouseDown(){
        Debug.Log("MouseDown");

        startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        startPos.z = 0;
    }

    void MouseUp(){
        Debug.Log("MouseUp");

        endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        endPos.z = 0;

        Vector2 direction = (endPos - startPos).normalized;

        Debug.Log("Casting a Ray from " + startPos + " Vector: " + direction);

        WindBlast(startPos, direction);
        
    }

    public void WindBlast(Vector3 startPos, Vector2 direction){

        RaycastHit2D hit = Physics2D.Raycast(startPos, direction, 100f, interactables);

        if (hit.collider != null){

            Debug.Log(hit.collider.name);
            
           IWindable wind =  hit.collider.GetComponent<IWindable>();

            Debug.Log("Wind Object Hit");
            wind.Wind(direction);


        }

    }
}

public interface IWindable {
    void Wind(Vector2 direction);
}
