using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float mouse = 1300f;

    public Transform playerBody; // Variable para coger solo un valor de un objeto.

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouse * Time.deltaTime;

        xRotation += mouseY;

        xRotation = Mathf.Clamp(xRotation, -40f, 40f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        playerBody.Rotate(Vector3.up * mouseX);

    }
}
