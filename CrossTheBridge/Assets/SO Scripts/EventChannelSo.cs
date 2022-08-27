using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName ="Events/Event Channel")]
public class EventChannelSo : ScriptableObject
{
    public UnityAction OnEventRaised;
    // Start is called before the first frame update
    public void eventRaised()
    {
        OnEventRaised?.Invoke();
    }
}
