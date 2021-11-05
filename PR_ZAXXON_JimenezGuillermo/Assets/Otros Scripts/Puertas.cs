using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{

    Velocidad velocidad;
    

    // Start is called before the first frame update
    void Start()
    {
        velocidad = GameObject.Find("Variable").GetComponent<Velocidad>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float speed = velocidad.speedObjects;
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if(transform.position.z <= 25)
        {
            if (gameObject.name == "PuertasR")
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        if(transform.position.z <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
