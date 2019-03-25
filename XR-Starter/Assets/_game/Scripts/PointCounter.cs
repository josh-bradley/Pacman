using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{

    private int score = 0;
    
    public void Increment()
    {
        score++;

        UnityEngine.UI.Text scoreText = GameObject.FindGameObjectWithTag("scoreText").GetComponent<UnityEngine.UI.Text>();

        scoreText.text = $"Score = {score}";

        Debug.Log("Score incremented");


    }
    
}
