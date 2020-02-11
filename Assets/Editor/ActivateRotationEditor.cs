
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(ActivateRotationComponent))]
public class ActivateRotationEditor : Editor
{


    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Rotate Component"))
        {
            ActivateRotationComponent activeNode = (ActivateRotationComponent)target;

            activeNode.Rotate();

        }

        base.OnInspectorGUI();

    }

}
