using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomManager : MonoBehaviour
{

    public GameObject northDoor;
    public GameObject eastDoor;
    public GameObject southDoor;
    public GameObject westDoor;

    public List<Direction> unlockDirections;

    public bool unlocked = false;

    public UnityEvent OnUnlock;


    public void Unlock(){

        if (unlocked != false)
        {
            return;
        }

        Debug.Log("Unlocking Room");

        foreach (Direction unlockDirection in unlockDirections){
            UnlockDoor(unlockDirection);
            Debug.Log(unlockDirection);
        }

        unlocked = true;

        OnUnlock.Invoke();
        
    }

    // Takes a direction as a parameter, determines which gameobject reference to attempt to deactivate. If it has a deactivate component, deactivate through that method, otherwise, simply deactivate the gameobject itself.
    private void UnlockDoor(Direction unlockDirection){

        GameObject doorToUnlock = null;

            switch (unlockDirection){

            case Direction.NORTH:
            doorToUnlock = northDoor;
            break;


            case Direction.EAST :
            doorToUnlock = eastDoor;
            break;

            case Direction.SOUTH :
            doorToUnlock = southDoor;
            break;
            

            case Direction.WEST :
            doorToUnlock = westDoor;
            break;

        }

        if (doorToUnlock == null){
            //Debug.Log("Door to unlock = null");
            return;
        }


        DeactivateComponent deactivate = doorToUnlock.GetComponent<DeactivateComponent>();

        if (deactivate != null){
            deactivate.Deactivate();

        } else {
            //Debug.Log("Deactivating: " + doorToUnlock);
            doorToUnlock.SetActive(false);
        }
        
        
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
