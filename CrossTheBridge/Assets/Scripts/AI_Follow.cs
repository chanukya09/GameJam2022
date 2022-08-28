using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Follow : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimumDistance;
    private bool follow = false;

    private void Update()
    {
        if(follow)
            if (Vector3.Distance(transform.position, target.position) > minimumDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }     
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            follow = true;
        }
    }


}
