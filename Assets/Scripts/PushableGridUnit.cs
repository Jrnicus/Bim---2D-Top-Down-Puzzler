using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GridMovementComponent))]
public class PushableGridUnit : MonoBehaviour, IWindable
{

private GridMovementComponent gridMovement;

    public void Wind(Vector2 direction)
    {
        if (gridMovement.moving == true){
            return;
        }

        gridMovement.Move(GetDirectionFromVector2(direction));
    }

    public Direction GetDirectionFromVector2(Vector2 dir){

        if (Mathf.Abs(dir.x) > Mathf.Abs(dir.y)){
            // up or down

            if (dir.x >= 0){
                return Direction.RIGHT;
            } else return Direction.LEFT;
        }

        else if (Mathf.Abs(dir.y) > Mathf.Abs(dir.x)){
            // up or down

            if (dir.y >= 0){
                return Direction.UP;
            } else return Direction.DOWN;
        }

        return Direction.DOWN;
        

    }

    // Start is called before the first frame update
    void Start()
    {
        gridMovement = GetComponent<GridMovementComponent>();
    }


    

}
