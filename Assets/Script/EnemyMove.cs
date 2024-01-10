using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

    public static float speed = 3.0f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}