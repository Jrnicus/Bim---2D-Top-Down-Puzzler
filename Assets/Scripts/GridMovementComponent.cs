using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GridMovementComponent : MonoBehaviour
{

    public float MoveSpeed = 1f;

    public GridNode currentNode;
    public GridNode targetNode;

    public bool moving = false;

    bool movingOneSpace = false;

    public UnityEvent tileMovedEvent;


    public void Start(){
        //Move(Direction.LEFT);
    }

    public void Move(Direction direction, bool oneSpace = false){

        GridNode nextNode = null;

        if (oneSpace){
         nextNode =  currentNode.GetNode(direction);
        }

        else if (!oneSpace){
            // this needs to be expanded upon so that we get traverse along nodes one at a time, if we are set to one space, then we continue in our direciton!
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

        else if (moving && transform.position == targetNode.transform.position){
            currentNode = targetNode;
            moving = false;

            tileMovedEvent.Invoke();
            
        }
    }

    
    
}
