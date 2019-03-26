using UnityEngine;

public class CatchPacman : MonoBehaviour
{
    public AudioClip gameOver;
    private AudioSource gameAudio;
    private bool GameOver = false;

    private void Awake()
    {
        gameAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!GameOver)
        {
            gameAudio.clip = gameOver;
            gameAudio.Play();
            GameOver = true;
        }
    }
}
