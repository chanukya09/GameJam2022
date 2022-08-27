using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AiCube : MonoBehaviour
{
    private StateMachine statemachine = new StateMachine();
    [SerializeField]
    private LayerMask foodItem;
    [SerializeField]
    private float viewRange;
    [SerializeField]
    private string foodItemTag;

    private NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {   
        this.agent = GetComponent<NavMeshAgent>();  
        statemachine.ChangeState(new SearchFor(this.foodItem, this.gameObject, this.viewRange, this.foodItemTag, this.agent));
    }
    private void Update()
    {
        this.statemachine.ExecuteStateUpdate();
    }
}
