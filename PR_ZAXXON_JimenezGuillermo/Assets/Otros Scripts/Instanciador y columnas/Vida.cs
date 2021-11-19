using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    [SerializeField] GameObject objetoVariable; // Creamos un objeto vacio el cual vamos a asociar un objeto mas adelante.
    public Velocidad velocidad; // Llamamos a una variable de la clase Velocidad donde luego cogeremos ese componente.

    private float speed; // Llamamos a la variable speed para meter dentro la variable velocidad del otro script.

    // Start is called before the first frame update
    void Start()
    {
        objetoVariable = GameObject.Find("Variable"); // Cogemos el GameObject y le decimos que encuentre en unity entre los objetos el que se llame como el que este entre parentesis.
        velocidad = objetoVariable.GetComponent<Velocidad>(); // Cogemos del componente que hemos seleccionado antes el script que se llama Velocidad.
    }

    // Update is called once per frame
    void Update()
    {
        speed = velocidad.speedObjects; // Le damos el valor a la variable que hemos nombrado al principio la variable llamada speed.
        ColumnaMoove(); // Hacemos que se mueva.
    }

    void ColumnaMoove()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
