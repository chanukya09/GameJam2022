using UnityEngine;
using UnityEngine.UI;

public class HealthUi : MonoBehaviour
{   
    public PlayerController playerController;
    public Text Score,Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void ScoreandHelath(int score,int health)
    {
        Score.text="Score"+ score;
        Health.text = "health" + health; 
    }
}
