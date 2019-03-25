﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityColourer : MonoBehaviour
{

    public Color farColour = Color.yellow;
    public Color closeColour = Color.green;
    public MeshRenderer mesh;
    float t = 0;
    public float threshold = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //t += Time.deltaTime;
        //t = t % 1;
        //mesh.material.color = Color.Lerp(farColour, closeColour, t);


        ;

        float dist = Vector3.Distance(mesh.transform.position, Camera.main.transform.position);
        

        if (dist < threshold)
        {
            mesh.material.color = closeColour;
            Destroy(mesh.gameObject);
            //mesh.transform.localScale.Scale = 0;
        }
        else
        {
            mesh.material.color = farColour;
        }
    }
}
