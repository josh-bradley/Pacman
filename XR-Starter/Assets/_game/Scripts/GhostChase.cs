using UnityEngine;

public class GhostChase : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(Camera.main.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
