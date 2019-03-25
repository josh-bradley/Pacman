using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{

    private int score = 0;

    public void Increment()
    {
        score++;
        Debug.Log("Score incremented");


    }
    
}
