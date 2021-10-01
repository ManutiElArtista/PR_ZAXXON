using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoovement : MonoBehaviour
{

    public CharacterController characterController;

    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        float x = Input.GetAxis("Horizontal");
        // float y = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Profundidad");
        // float jump = Input.GetAxis("Jump");

        Vector3 move = transform.right * x + transform.forward * z; // Creamos un nuevo Vector3 el cual va a coger los diferentes valores y los va a sumar para que podamos movernos.

        characterController.Move(move * speed * Time.deltaTime); // Le decimos que el valor Move del character controller va a ser el vector 3 que hemos creado llamado move.
    }
}
