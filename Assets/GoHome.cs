using UnityEngine;
using UnityEngine.AI;

public class GoHome : MonoBehaviour
{
    public Transform home;
    private NavMeshAgent _agent;

    private void Start() {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        _agent.SetDestination(home.position);
    }
}
