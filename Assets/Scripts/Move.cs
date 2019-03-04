using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float mouseSensitivity = 100.0f;
    //public float clampAngle = 30.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis
    //default
    //public float Control_Horizontal_Right = 360f;
    //public float Control_Horizontal_Left = 0f;
    public float Control_Vertical_UP = -45f;
    public float Control_Vertical_Down = 45f;

    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    void Update()
    {
       
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = -Input.GetAxis("Mouse Y");

            rotY += mouseX * mouseSensitivity * Time.deltaTime;
            rotX += mouseY * mouseSensitivity * Time.deltaTime;

            rotX = Mathf.Clamp(rotX, Control_Vertical_UP, Control_Vertical_Down);
            //rotY = Mathf.Clamp(rotY, -Control_Horizontal_Left, Control_Horizontal_Right);

            Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
            transform.rotation = localRotation;
        }

    }
}