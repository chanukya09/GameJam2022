using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyTrapSensor : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("1");
            this.gameObject.GetComponentInParent<Deadly_Trap>().Push();
            
        }
    }
}
