using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovementComponent : MonoBehaviour
{

    public float MoveSpeed = 1f;

    public GridNode currentNode;
    public GridNode targetNode;

    bool moving = false;


    public void Start(){
        Move(Direction.LEFT);
    }

    public void Move(Direction direction, bool oneSpace = false){

        GridNode nextNode = null;

        if (oneSpace){
         nextNode =  currentNode.GetNode(direction);
        }

        else if (!oneSpace){
            nextNode = currentNode.GetFurthestNode(direction);
        }

        

        if (nextNode != null){
            targetNode = nextNode;
            moving = true;
        }

    }

    public void Update(){

        if (moving && transform.position != targetNode.transform.position){
            transform.position = Vector3.MoveTowards(transform.position, targetNode.transform.position, MoveSpeed * Time.deltaTime);
            
        }

        else if (transform.position == targetNode.transform.position){
            currentNode = targetNode;
            moving = false;
        }
    }

    
    
}
