using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Listener : MonoBehaviour
{

    public RaiseEventSO HealthChannel ;
    public RaiseEventSO scoreChannel;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    public float apple=0;
    
    private void OnEnable()
    {
        HealthChannel.OnEventRaised += UpdateHealth;
        HealthChannel.OnEventRaised += updateapple;
        scoreChannel.OnEventRaised += score;


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        HealthChannel.OnEventRaised -= UpdateHealth;
        HealthChannel.OnEventRaised -= updateapple;
        scoreChannel.OnEventRaised -= score;
    }

    void UpdateHealth(int Health)
    {
        healthText.text = "Health is" + Health;
    }
    void updateapple(int a)
    {
        apple = a;
    }
    void score(int b)
    {
        scoreText.text = "score is" + b;
    }
}
