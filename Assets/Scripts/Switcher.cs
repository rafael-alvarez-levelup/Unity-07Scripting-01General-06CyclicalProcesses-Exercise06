using UnityEngine;

public class Switcher : MonoBehaviour
{
    public bool IsSwitched { get; private set; }

    public delegate void SwitchedHandler();

    public event SwitchedHandler SwitchChange;

    private void Start()
    {
        IsSwitched = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsSwitched)
        {
            IsSwitched = true;

            OnSwitchChange();
        }
    }

    private void OnSwitchChange()
    {
        if (SwitchChange != null)
        {
            SwitchChange.Invoke();
        }
    }
}
