using UnityEngine;

public class ScaleWithCameraDistance : MonoBehaviour
{
    public Camera mainCamera;
    private Vector3 initialScale;
    private float initialDistance;

    void Start()
    {
        initialScale = transform.localScale;
        initialDistance = Vector3.Distance(transform.position, mainCamera.transform.position);
    }

    void Update()
    {
        float currentDistance = Vector3.Distance(transform.position, mainCamera.transform.position);
        transform.localScale = initialScale * (currentDistance / initialDistance);
    }
}
