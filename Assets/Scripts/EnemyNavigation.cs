using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    private Enemy enemy;
    public GameObject END;
    public NavMeshAgent agent;
    
    void Start()
    {
        enemy = GetComponent<Enemy>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = END.transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, END.transform.position) <= 0.2f)
        {
            EndPath();
        }
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.enemiesAlive--;
        Destroy(gameObject);
    }
}
