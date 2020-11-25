using UnityEngine;
using UnityEngine.Events;

public class EndPoint : MonoBehaviour
{
    public UnityEvent OnReached;

    public bool IsReached { get; private set; }

    private void Start()
    {
        IsReached = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsReached)
        {
            IsReached = true;

            EndPointReached();
        }
    }

    private void EndPointReached()
    {
        OnReached.Invoke();
    }
}