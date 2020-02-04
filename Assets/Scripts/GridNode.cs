using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

    public enum Direction{
        WEST, EAST, NORTH, SOUTH
    }

public class GridNode : MonoBehaviour
{
    public float gridDistance = 1f;

    public GridNode left;
    public GridNode right;
    public GridNode up;
    public GridNode down;


    public Transform GetLink(Direction direction){

        GridNode nextNode = GetNode(direction);

        if (nextNode != null){
            return nextNode.transform;
        }

        return null;
    }

    public GridNode GetNode(Direction direction){

        switch (direction){
            case Direction.SOUTH:
            return down;
            

            case Direction.NORTH: 
            return up;

            case Direction.EAST:
            return right;

            case Direction.WEST: 
            return left;
        }

        return null;

    }

    public GridNode GetFurthestNode(Direction direction){

        GridNode nextNode = this.GetNode(direction);

        if (nextNode != null && nextNode.GetNode(direction) != null){
             return nextNode.GetFurthestNode(direction);
        } else if (nextNode != null){
            return nextNode;
        }

        return null;

    }



    public GridNode SpawnNode(Vector3 position)
    {
        GridNode newNode = Instantiate(this.gameObject, position, Quaternion.identity).GetComponent<GridNode>();

        newNode.ClearLinks();

        return newNode;
    }

    public void ClearLinks(){
        this.left = null;
        this.right = null;
        this.up = null;
        this.down = null;
    }

    public GameObject SpawnNode(Direction direction){
        Vector3 spawnPos = transform.position;

        switch (direction){
            case Direction.SOUTH:
                spawnPos += new Vector3 (0, -gridDistance, 0);
            break;

            case Direction.NORTH: 
                spawnPos += new Vector3(0, gridDistance);
            break;

            case Direction.EAST:
                spawnPos += new Vector3 (gridDistance, 0);
            break;

            case Direction.WEST: 
                spawnPos += new Vector3(-gridDistance, 0);
            break;
        }

        GridNode newNode = SpawnNode(spawnPos);

        SetLink(newNode, direction);

        return newNode.gameObject;

    }

    public void SetLink(GridNode node, Direction direction){

        switch (direction){

            case Direction.SOUTH:
            this.down = node;
            node.up = this;
            break;
       
            case Direction.NORTH:
            this.up = node;
            node.down = this;
            break;

            case Direction.EAST:
            this.right = node;
            node.left = this;
            break;

            case Direction.WEST:
            this.left = node;
            node.right = this;
            break;
            
        }

    }

}
