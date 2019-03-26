using UnityEngine;

public class SpawnGhosts : MonoBehaviour
{
    public GameObject ghost;
    public float rateOfSpawn = 1;
    public int maxGhosts = 4;
    private float lastSpawnTime = 0;
    private Color[] ghostColors = new Color[] { Color.red, Color.cyan, Color.green, Color.magenta };
    private int ghostCounter = 0;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > lastSpawnTime + rateOfSpawn && ghostCounter < maxGhosts)
        {
            SpawnGhost();
        }
    }

    private void SpawnGhost()
    {
        var idx = ghostCounter % ghostColors.Length;
        var currentColor = ghostColors[idx];
        var go = Instantiate(ghost, gameObject.transform.position, Quaternion.identity);
        var newMaterial = new Material(Shader.Find("MixedRealityToolkit/Standard"));
        newMaterial.color = currentColor;
        go.GetComponentInChildren<MeshRenderer>().material = newMaterial;
        lastSpawnTime = Time.time;
        ghostCounter++;
    }
}
