using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent agent;
    public Animator Enemyanimator;
    private Rigidbody rb;

    public GameObject AlarmText;
    public GameObject text;

    public static float speed = 2.0f;
    public static bool isStopped = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        rb = GetComponent<Rigidbody>();
        Player = FindObjectOfType<PlMove>().transform;
        text.SetActive(false);
    }

    void Update()
    {
        agent.speed = speed;
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

            text.SetActive(true);

            rb.isKinematic = true;
            rb.detectCollisions = false;
        }
    }
}