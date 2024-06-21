using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        Vector3 cameraPosition = new Vector3(mainCamera.transform.position.x, transform.position.y, mainCamera.transform.position.z);
        transform.LookAt(cameraPosition);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
