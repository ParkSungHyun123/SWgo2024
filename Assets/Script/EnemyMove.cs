using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent agent;
    public Animator Enemyanimator;
    private Rigidbody rb;

    public static float speed = 3.0f;
    private bool isStopped = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        rb = GetComponent<Rigidbody>();
        Player = FindObjectOfType<PoliceMove>().transform;
    }

    void Update()
    {
        if (!isStopped)
        {
            agent.SetDestination(Player.position);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Police")
        {
            isStopped = true;
            agent.isStopped = true;
            Enemyanimator.SetBool("Gumger", true);

            rb.isKinematic = true;
            rb.detectCollisions = false;
        }
    }
}