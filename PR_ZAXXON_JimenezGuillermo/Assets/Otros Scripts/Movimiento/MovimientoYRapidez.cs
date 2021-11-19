 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoYRapidez : MonoBehaviour
{

    // [SerializeField] float despSpeed;
    // [SerializeField] float rotationSpeed = 10f;
    private float limitX = 14f;
    // private float limitNY = 0.05f;
    // private float limitY = 5f;

    [SerializeField] GameObject objetoVariable;
    public Velocidad velocidad;

    // Start is called before the first frame update
    void Start()
    {
        objetoVariable = GameObject.Find("Variable");
        velocidad = objetoVariable.GetComponent<Velocidad>();
    }

    // Update is called once per frame
    void Update()
    {
        Moove();
    }

    void Moove()
    {
        float despY;
        float despX;
        float desplR;

        float posX = transform.position.x;
        float posY = transform.position.y;
        
        despY = Input.GetAxis("Vertical");
        despX = Input.GetAxis("Horizontal");
        desplR = Input.GetAxis("Rotation");

        transform.Rotate(0f, 0f, desplR * Time.deltaTime * velocidad.speed);

        if ((posX < limitX || despX < 0f) && (posX > -limitX || despX > 0f))
        {
            transform.Translate(Vector3.right * despX * Time.deltaTime * velocidad.speed, Space.World);
        }     

        if((posY > 0.05f || despY > 0f) && (posY < 5f || despY < 0f)) // Condicion de que si la posicion es mayor que la de abajo (Caso vertical) o lo estoy desplazando hacia arriba, que lo mueva YYYYY si 
        {
            transform.Translate(Vector3.up * despY * Time.deltaTime * velocidad.speed, Space.World); // El Space.World se utiliza para que a la hora de rotar, rote de manera normal y se mueva hacia arriba y no coja los valores del transform.
        }
    }

    /*void Restriccion(float despX, float despY)
    {
        if (transform.position.x < -limitX && despX > 0)
        {
            transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitX && despX < 0)
        {
            transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        }

        if(transform.position.y < 0.05f && despY > 0)
        {
            transform.position = new Vector3(transform.position.x, limitNY, transform.position.z);
        }
        if(transform.position.y > 5f && despY < 0)
        {
            transform.position = new Vector3(transform.position.x, limitY, transform.position.z);
        }
    }*/
}
