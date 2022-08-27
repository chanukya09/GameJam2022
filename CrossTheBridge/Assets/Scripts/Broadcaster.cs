using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broadcaster : MonoBehaviour
{
    public int addHealth= 1;
    public int currentHealth=2;
    public int maxHealth = 3;
    public int score = 1;
    public RaiseEventSO HealthUpdate;
    public RaiseEventSO scoreUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Orb"))
        {
            /*if (currentHealth < maxHealth)
            {
                currentHealth += addHealth;
                Destroy(other.gameObject);
            }*/
            HealthUpdate.EventRaised(addHealth);
        }
        if (other.CompareTag("Score"))
        {
            scoreUpdate.EventRaised(score);
        }
    }


}
