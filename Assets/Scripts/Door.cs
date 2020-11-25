using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Switcher switcher;

    private void OnEnable()
    {
        switcher.OnActivated.AddListener(OpenDoor);
    }

    private void OnDisable()
    {
        switcher.OnActivated.RemoveListener(OpenDoor);
    }

    private void OpenDoor()
    {
        Vector3 originalPosition = transform.position;
        Vector3 newPosition = new Vector3(originalPosition.x, originalPosition.y + 2.5f, originalPosition.z);

        const float time = 2f;

        StartCoroutine(transform.LerpTransformationRoutine(originalPosition, newPosition, time));
    }
}