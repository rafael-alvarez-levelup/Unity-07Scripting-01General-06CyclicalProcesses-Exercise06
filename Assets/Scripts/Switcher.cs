using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Switcher : MonoBehaviour
{
    public UnityEvent OnActivated;

    public bool IsSwitched { get; private set; }

    private void Start()
    {
        IsSwitched = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsSwitched)
        {
            IsSwitched = true;

            StartCoroutine(HideSwitcherRoutine());
        }
    }

    private IEnumerator HideSwitcherRoutine()
    {
        Vector3 originalPosition = transform.position;
        Vector3 newPosition = new Vector3(originalPosition.x, originalPosition.y - 0.4f, originalPosition.z);

        const float time = 2f;

        yield return StartCoroutine(transform.LerpTransformationRoutine(originalPosition, newPosition, time));

        SwitcherActivated();
    }

    private void SwitcherActivated()
    {
        OnActivated.Invoke();
    }
}