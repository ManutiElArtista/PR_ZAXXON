using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{

    [SerializeField] Text textoTerminando;

    int time; // Tiempo que vas a obtener puntos.
    int cont; // Contador de puntos.

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Numeros"); // Llamamos corrutina.
        time = 1;
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Numeros() // Puntuacion de tiempo cada 1 segundo.
    {
        while (true)
        {
            textoTerminando.text = "Puntuacion: " + cont;
            yield return new WaitForSeconds(time);
            cont++;
        }
    }

    public void ParaNumeros()
    {
        StopCoroutine("Numeros");
    }

}
