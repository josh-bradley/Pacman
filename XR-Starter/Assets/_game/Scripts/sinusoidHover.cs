using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinusoidHover : MonoBehaviour
{

    public float frequency = 0.6f;  // Speed of sine movement
    public float magnitude = 0.05f;   // Size of sine movement
    private Vector3 axis; // direction of oscillation

    private Vector3 pos; // quiescent position
    private float offset; // for making each ball different

    void Start()
    {
        pos = transform.position;
        //DestroyObject(gameObject, 1.0f);
        axis = transform.up;
        offset = Random.value * 2 * Mathf.PI;

    }

    void Update()
    {
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency * (2* Mathf.PI) + offset) * magnitude;
    }
}
