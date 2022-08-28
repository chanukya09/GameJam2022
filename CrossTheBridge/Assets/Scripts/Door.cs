using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject gb;
    private Vector3 doorpos = new Vector3(0.519f,0,0);

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate()
    {
        gb.transform.RotateAround(transform.position+doorpos, Vector3.up, 90);
    }
   
}
