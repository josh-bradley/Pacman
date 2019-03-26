using UnityEngine;

public class GhostChase : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Vector3 home;
    public GameObject body;
    public Material boostColor;
    private MeshRenderer meshRenderer;
    private bool boostActive = false;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = body.GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if(!boostActive)
            agent.SetDestination(Camera.main.transform.position);
    }

    public void OnBoost()
    {
        boostActive = true;
        agent.SetDestination(home);
        meshRenderer.material = boostColor;
    }

    public void Caught()
    {
        meshRenderer.enabled = false;
    }
}
