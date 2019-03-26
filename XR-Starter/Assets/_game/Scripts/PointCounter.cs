using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{

    private int score = 0;
    TMPro.TextMeshPro scoreText;

    public void Start()
    {
        Debug.Log("Initialising score");
        score = 0;
        GameObject go = GameObject.FindGameObjectWithTag("scoreText");
        scoreText = go.GetComponent<TMPro.TextMeshPro>();
        scoreText.text = $"Score = {score}";
    }

    public void Increment()
    {
        score++;

        scoreText.text = $"Score = {score}";

        Debug.Log("Score incremented");


    }

}
