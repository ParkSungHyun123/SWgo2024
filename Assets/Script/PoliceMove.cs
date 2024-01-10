using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoliceMove : MonoBehaviour
{
    private Transform Enemy; 
    private NavMeshAgent agent;

    public static float speed = 4.0f;

    void Start()
    {
        Enemy = FindObjectOfType<EnemyMove>().transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }
    void Update()
    {
        agent.SetDestination(Enemy.position);
    }
}