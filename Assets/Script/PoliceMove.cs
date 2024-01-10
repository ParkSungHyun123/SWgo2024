using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoliceMove : MonoBehaviour
{
    private Transform Enemy;
    private NavMeshAgent agent;
    public Animator animator;
    private Rigidbody rb;

    public static float speed = 5.0f;
    private bool isStopped = false;

    void Start()
    {
        Enemy = FindObjectOfType<EnemyMove>().transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isStopped)
        {
            agent.SetDestination(Enemy.position);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            isStopped = true;
            agent.isStopped = true;
            animator.SetBool("Catch", true);

            rb.isKinematic = true;
            rb.detectCollisions = false;
        }
    }
}