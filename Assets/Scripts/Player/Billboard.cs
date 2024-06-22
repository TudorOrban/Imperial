using UnityEngine;

public class Billboard : MonoBehaviour
{

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector3 cameraEulerAngles = mainCamera.transform.eulerAngles;
        Quaternion targetRotation = Quaternion.Euler(0, 270, 0); // Fix Y to 270 degrees
        transform.rotation = targetRotation;
        transform.LookAt(transform.position + Quaternion.Euler(0, cameraEulerAngles.y, 0) * Vector3.forward);
    }
}
