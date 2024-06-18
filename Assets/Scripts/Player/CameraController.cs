using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 50.0f;
    public float zoomSpeed = 10.0f;
    public float minZoomDistance = 10.0f;
    public float maxZoomDistance = 50.0f;

    private Vector3 cameraStartPosition;

    private void Start()
    {
        cameraStartPosition = transform.position;   
    }

    private void Update()
    {
        HandleMovement();
        //HandleZoom();

        
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 forwardMovement = transform.forward * vertical;
        Vector3 sideMovement = transform.right * horizontal;

        forwardMovement.y = 0;
        sideMovement.y = 0;

        transform.position += forwardMovement + sideMovement;
    }

    void HandleZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 zoomDirection = transform.forward * scroll * zoomSpeed * 100.0f * Time.deltaTime;
        
        Vector3 newPosition = transform.position + zoomDirection;
        if ((newPosition - cameraStartPosition).magnitude > minZoomDistance && (newPosition - cameraStartPosition).magnitude < maxZoomDistance)
        {
            transform.position += newPosition;
        }
    }
}
