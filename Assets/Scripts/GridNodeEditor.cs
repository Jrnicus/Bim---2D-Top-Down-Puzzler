
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
            objects[0] = activeNode.SpawnNode(Direction.UP);
            Selection.objects = objects;

        }

        if (GUILayout.Button("EastNode")){

            GridNode activeNode = (GridNode)target;
            GameObject[] objects = new GameObject[1];
            objects[0] = activeNode.SpawnNode(Direction.RIGHT);
            Selection.objects = objects;

        }
        

        if (GUILayout.Button("SouthNode")){

            GridNode activeNode = (GridNode)target;
            GameObject[] objects = new GameObject[1];
            objects[0] = activeNode.SpawnNode(Direction.DOWN);


            Selection.objects = objects;

        }

        if (GUILayout.Button("WestNode")){

            GridNode activeNode = (GridNode)target;
            GameObject[] objects = new GameObject[1];
            objects[0] = activeNode.SpawnNode(Direction.LEFT);
            Selection.objects = objects;

        }

    base.OnInspectorGUI();

    }

}
