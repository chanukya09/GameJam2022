using UnityEngine;
using UnityEngine.AI;

public class SearchFor : IState
{   
    private LayerMask layerMask;

    public GameObject ownerGameObject;
    private float searchRadius;
    private string tagToLookFor;
    NavMeshAgent navMeshAgent;

    public SearchFor(LayerMask layerMask,GameObject ownerGameObject,float searchRadius,string tagToLookFor,NavMeshAgent navMeshAgent)
    {
        this.layerMask = layerMask;
        this.ownerGameObject = ownerGameObject;
        this.searchRadius = searchRadius;
        this.tagToLookFor=tagToLookFor;
        this.navMeshAgent = navMeshAgent;
        
    }

    void IState.Enter()
    {

    }

    void IState.Execute()
    {
        var HitObjects = Physics.OverlapSphere(this.ownerGameObject.transform.position,this.searchRadius);
#pragma warning disable CS0162 // Unreachable code detected
        for (int i = 0; i < HitObjects.Length; i++)
        {
            if (HitObjects[i].CompareTag(this.tagToLookFor)){
                this.navMeshAgent.SetDestination(HitObjects[i].transform.position);
            }
            break;
        }
#pragma warning restore CS0162 // Unreachable code detected
    }

    void IState.Exit()
    {

    }
}
