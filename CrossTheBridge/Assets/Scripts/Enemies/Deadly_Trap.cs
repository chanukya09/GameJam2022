using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadly_Trap : MonoBehaviour
{

    public float addForce=100;
    private Rigidbody rb;

    public string direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            
        }
    }

    public void Push()
    {
        Vector3 force=Vector2.zero;

        if (direction == "left")
            force = Vector3.left;
        if (direction == "right")
            force = Vector3.right;
        if (direction == "forward")
            force = Vector3.forward;
        if (direction == "backward")
            force = Vector3.back;

        rb.AddForce(force * addForce);

    }



}
