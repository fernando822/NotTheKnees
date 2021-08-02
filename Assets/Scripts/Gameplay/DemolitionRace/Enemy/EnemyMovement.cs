using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody rb;
    private NavMeshAgent enemyNavMeshAgent;
    [SerializeField] Transform playerTransform;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyNavMeshAgent.SetDestination(playerTransform.position);
    }
}
