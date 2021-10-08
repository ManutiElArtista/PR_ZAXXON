using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorColumna : MonoBehaviour
{

    float intervalo;

    [SerializeField] GameObject columna; // Le decimos que vamos a pasarle un objeto a este objeto que lo llamamos columna.
    [SerializeField] Transform instantiatePosition; // Le decimos que salgan desde la posicion que tenga el objeto que le pasemos.

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.3f;

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
            float randomX = Random.Range(-14f, 14f);
            Vector3 newPos = new Vector3(randomX, instantiatePosition.position.y, instantiatePosition.position.z);
            Instantiate(columna, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }
    }
}

