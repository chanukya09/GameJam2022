using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName ="ScriptableObjects/Health")]
public class RaiseEventSO : ScriptableObject
{
    public UnityAction<int> OnEventRaised;
    // Start is called before the first frame update
    public void EventRaised(int value)
    {
        OnEventRaised?.Invoke(value);
    }
}
