using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform spawnPoint; // Para coger el transform del objeto.

    public GameObject bullet; // Para instanciar un objeto en el.

    public float shootForce = 1500f; // Va a ser la potencia de la bala.
    public float shootRate = 0.5f; // Cada cuanto se puede disparar.

    private float shootRateTime = 0; // Contador para ver si puede disparar.

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // Si pulsamos este boton, hara lo siguiente.
        {
            GameObject newBullet; // NO entiendo para que se usa esto.

            newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation); // Instanciamos la bala en la posicion del spawnPoint con la rotacion y posicion que tenga 
                                                                                       // diciendo que el objeto puesto en la variable "bullet" es el que saldra de ella.

        }
    }
}
