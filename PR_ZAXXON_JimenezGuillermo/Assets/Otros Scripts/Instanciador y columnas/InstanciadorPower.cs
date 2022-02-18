using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorPower : MonoBehaviour
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

    }

    IEnumerator CrearColumna()
    {
        while (true)
        {
            float randomX = Random.Range(-14f, 14f); // Le damos un valor aleatorio para que salga entre dos posiciones, minima y maxima.
            float randomY = Random.Range(0.05f, 5f); // Le damos un valor aleatorio para que salga entre dos posiciones, minima y maxima.

            Vector3 newPosY = new Vector3(randomX, randomY, instantiatePosition.position.z); // Le decimos que el random Y y el randomX sea una nueva posicion.

            int numAl = Random.Range(0, obstaculos.Length); // Creamos una variable que diga que sea un numero aleatorio entre el valor 0 (1) y el valor maximo va a ser el numero maximo de objetos que le hayamos instanciado.

            Instantiate(obstaculos[numAl], newPosY, Quaternion.identity); // Instanciamos al objeto que tenga el script el objeto aleatorio que haya salido anteriormente, con la posicion creada anteriormente y misma rotacion.

            yield return new WaitForSeconds(intervalo);
        }
    }

    public void PararCorrutina()
    {
        print("He parado");
        StopCoroutine("CrearColumna");
    }

    /*void CrearColumnasIniciales()
    {

        float posZ = instantiatePos.position.z;
        float columnasIniciales = (posZ - posZcolumna1) / distance;

        columnasIniciales = Mathf.Round(columnasIniciales);
        print(columnasIniciales);

        for (float n = posZcolumna1; n < posZ; n += distance)
        {
            float randomX = Random.Range(limiteL, limiteR);

            Vector3 columnaInicialPos = new Vector3(randomX, instantiatePos.position.y, n);
            Instantiate(obstaculos[0], columnaInicialPos, Quaternion.identity);
        }
    }*/
}
