using UnityEngine;

public class GhostChase : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Vector3 home;
    public GameObject body;
    public Material boostColor;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = body.GetComponent<MeshRenderer>();
        agent.SetDestination(Camera.main.transform.position);
    }

    public void OnBoost()
    {
        agent.SetDestination(home);
        meshRenderer.material = boostColor;
    }

    public void Caught()
    {
        meshRenderer.enabled = false;
    }
}
