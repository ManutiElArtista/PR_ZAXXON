using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoove : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    //Variables necesarias para la opción de suavizado
    [SerializeField] float smoothVelocity = 0.05f;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;

    // float positY = playerPosition.transform.position.y;
    // float positZ = playerPosition.transform.position.z;

    // Start is called before the first frame update
    void Start()
    {
        // positY += 1;
        // positZ += 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        //Con este código, conseguimos que siga al objeto pero con suavidad
        //La velocidad de suavizado, cuanto menor sea más brusco será el movimiento
        Vector3 targetPosition = new Vector3(playerPosition.transform.position.x, playerPosition.transform.position.y + 0.5f, transform.position.z); // Cogemos la posicion de referencia del jugador.
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity); // Colocamos la camara en la posicion que queremos.
    }
}
