using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] Transform instObject; // Le indicamos la posicion desde la cual va a salir el objeto.
    [SerializeField]  GameObject prefabBullet; // Le indicamos que objeto va a salir desde la posicion.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisparoMet();
    }

    void DisparoMet()
    {
        if (Input.GetKeyDown("mouse 0")) // Si se pulsa el boton izquiero del raton.
        {
            Instantiate(prefabBullet, instObject.transform.position, instObject.transform.rotation); // Instanciar el objeto correctametne.
        }
    }
}
