using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class AngledLightComponent : MonoBehaviour
{


    public Light2D light;

    public float angle = 45f;
    public float outerAngleDifference = 10f;

    public float radiusLength;

    public LayerMask queryLayers;

    public Color color = Color.white;


    private void OnValidate()
    {
        light.pointLightOuterAngle = angle + outerAngleDifference;
        light.pointLightInnerAngle = angle;

        light.pointLightOuterRadius = radiusLength + 0.5f;
        light.pointLightInnerRadius = radiusLength * 0.85f;

        light.color = this.color;
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
