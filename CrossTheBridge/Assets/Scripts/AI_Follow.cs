using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Follow : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimumDistance;
    private bool follow = false;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if(follow)
            if (Vector3.Distance(this.transform.position, target.position) > minimumDistance)
            {
                //agent.SetDestination(target.position);
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            follow = true;
        }
    }
    


}
