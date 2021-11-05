using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorColumna : MonoBehaviour
{
    [SerializeField] GameObject vidasGameObject;
    // public int cont;

    float intervalo;

    // [SerializeField] GameObject columna; // Le decimos que vamos a pasarle un objeto a este objeto que lo llamamos columna.
    [SerializeField] Transform instantiatePosition; // Le decimos que salgan desde la posicion que tenga el objeto que le pasemos.

    [SerializeField] GameObject[] obstaculos; // Creamos un objeto de tipo array para llamar diferentes objetos.

    // Start is called before the first frame update
    void Start()
    {

        vidasGameObject = GameObject.Find("Player");
        // cont = Vidas.contLife; // Para coger el valor de una variable estatica.

        intervalo = 1f; // Velocidad a la que salen los obstaculos.
        StartCoroutine("CrearColumna");
    }

    // Update is called once per frame
    void Update()
    {
        pararCorrutina();
    }

    IEnumerator CrearColumna()
    {
        while (true)
        {
            float randomX = Random.Range(-14f, 14f); // Le damos un valor aleatorio para que salga entre dos posiciones, minima y maxima.
            float randomY = Random.Range(0.05f, 5f); // Le damos un valor aleatorio para que salga entre dos posiciones, minima y maxima.

            Vector3 newPos = new Vector3(randomX, instantiatePosition.position.y, instantiatePosition.position.z); // Le decimos que random es un nuevo vector 3 que es el valo
            Vector3 newPosY = new Vector3(randomX, randomY, instantiatePosition.position.z); // Le decimos que el random Y y el randomX sea una nueva posicion.

            int numAl = Random.Range(0, obstaculos.Length); // Creamos una variable que diga que sea un numero aleatorio entre el valor 0 (1) y el valor maximo va a ser el numero maximo de objetos que le hayamos instanciado.
            
            if (obstaculos[numAl].tag == "Piramide") // Le decimos que si el tag del gameObject sea Piramide, que salga aleatorio en posicion X e Y.
            {
                Instantiate(obstaculos[numAl], newPosY, Quaternion.identity);
            }

            else
            {
                Instantiate(obstaculos[numAl], newPos, Quaternion.identity); // Instanciamos al objeto que tenga el script el objeto aleatorio que haya salido anteriormente, con la posicion creada anteriormente y misma rotacion.
            }

            yield return new WaitForSeconds(intervalo);
        }
    }

    public void pararCorrutina()
    {
        if (Vidas.contLife == 0)
        {
            print("Parar corrutina");
            StopCoroutine("CrearColumna");
        }
    }
}
