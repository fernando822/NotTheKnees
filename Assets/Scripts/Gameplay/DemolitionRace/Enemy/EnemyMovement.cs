using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rb;
    private NavMeshAgent enemyNavMeshAgent;
    [SerializeField] Transform playerTransform;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        enemyNavMeshAgent.SetDestination(playerTransform.position);
    }
}
