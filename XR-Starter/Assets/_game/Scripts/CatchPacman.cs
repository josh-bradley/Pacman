using UnityEngine;

public class CatchPacman : MonoBehaviour
{
    public AudioClip gameOver;
    public GameObject GhostSpawnPoint;
    private SpawnGhosts spawnGhosts;
    private AudioSource gameAudio;
    private bool GameOver = false;
    private bool boostActive = false;

    private void Awake()
    {
        spawnGhosts = GhostSpawnPoint.GetComponent<SpawnGhosts>();
        gameAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boost")
        {
            spawnGhosts.Boost();
            Destroy(other.gameObject);
            boostActive = true;
        }
        else if (other.gameObject.tag == "Ghost" && !GameOver)
        {
            if (boostActive)
            {
                var ghostChase = other.gameObject.GetComponent<GhostChase>();
                ghostChase.Caught();
            }
            else
            {
                gameAudio.clip = gameOver;
                gameAudio.Play();
                GameOver = true;
            }
        }
    }
}
