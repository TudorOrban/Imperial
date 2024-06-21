using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; 
    }

    void LateUpdate() 
    {
        transform.LookAt(transform.position + mainCamera.transform.forward);
    }
}