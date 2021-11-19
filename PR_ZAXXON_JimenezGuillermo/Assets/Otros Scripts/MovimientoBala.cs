using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 15f); // Se mueva hacia el forward a la velocidad de 15.
        if (transform.position.z > 100) // Si supera la posicion Z en 100, se destruya la bala sola.
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) // Cuando la bala toque algun objeto con otro collider.
    {
        if(other.gameObject.tag == "Destructor") // Cuando choque con un objeto con el tag Destructor.
        {
            // print("TOCADO");
            Destroy(other.gameObject); // Elimine el objeto que toca.
            Destroy(gameObject); // Elimine el objeto bala.
        }
    }
}
