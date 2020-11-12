using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public bool IsEnter { get; private set; }

    public delegate void EndPointHandler();

    public static event EndPointHandler EndPointChange;

    private void Start()
    {
        IsEnter = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsEnter)
        {
            IsEnter = true;
            OnEndPointChange();
        }
    }

    private void OnEndPointChange()
    {
        if (EndPointChange != null)
        {
            EndPointChange.Invoke();
        }
    }
}
