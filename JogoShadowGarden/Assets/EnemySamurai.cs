using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySamurai : MonoBehaviour
{
    [SerializeField] float damage;
    float lastAttackTime = 0;
    float attackCooldown = 2;

    [SerializeField] float stoppingDistance;

    NavMeshAgent agent;
    Animator anim;

    GameObject target, notTarget;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player");
        notTarget = GameObject.FindGameObjectWithTag("teste");
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if (dist > stoppingDistance)
        {
            Patrolling();
        }
        else
        {
            GoToTarget();
        }
    }

    private void GoToTarget()
    {
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
        anim.SetBool("isRunning", true);
    }

    private void Patrolling()
    {
        agent.SetDestination(notTarget.transform.position);
        anim.SetBool("isWalking", true);
    }

    private void StopEnemy()
    {
        agent.isStopped = true;
        anim.SetBool("isRunning", false);
    }

    /*/private void Attack()
    {
        if (Time.time - lastAttackTime >= attackCooldown)
        {
            lastAttackTime = Time.time;
            target.GetComponent<Character>().TakeDamage(damage); 
        }
    }*/

}
