using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform target; // The player's transform
    public float distance = 5.0f;
    public float sensitivity = 2.0f;
    public float minYAngle = -30.0f;
    public float maxYAngle = 70.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public GameObject player;
    private Vector3 offset = new Vector3(0.0f,3f,-2f);
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Get mouse movement input
        yaw += Input.GetAxis("Mouse X") * sensitivity;
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;
        pitch = Mathf.Clamp(pitch, minYAngle, maxYAngle);

        // Calculate rotation and position offset
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);
        Vector3 position = target.position - (rotation * Vector3.forward * distance);

        transform.rotation = rotation;
        transform.position = position;
    }
}
