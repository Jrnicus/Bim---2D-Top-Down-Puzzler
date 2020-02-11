
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(GridNode))]
public class GridNodeEditor : Editor
{


    public override void OnInspectorGUI(){

        GUILayout.Label("Spawn Nodes");

        

        if (GUILayout.Button("NorthNode")){

            GridNode activeNode = (GridNode)target;

            
            GameObject[] objects = new GameObject[1];    
            objects[0] = activeNode.SpawnNode(Direction.NORTH);
            Selection.objects = objects;

        }

        if (GUILayout.Button("EastNode")){

            GridNode activeNode = (GridNode)target;
            GameObject[] objects = new GameObject[1];
            objects[0] = activeNode.SpawnNode(Direction.EAST);
            Selection.objects = objects;

        }
        

        if (GUILayout.Button("SouthNode")){

            GridNode activeNode = (GridNode)target;
            GameObject[] objects = new GameObject[1];
            objects[0] = activeNode.SpawnNode(Direction.SOUTH);


            Selection.objects = objects;

        }

        if (GUILayout.Button("WestNode")){

            GridNode activeNode = (GridNode)target;
            GameObject[] objects = new GameObject[1];
            objects[0] = activeNode.SpawnNode(Direction.WEST);
            Selection.objects = objects;

        }

    base.OnInspectorGUI();

    }

}
