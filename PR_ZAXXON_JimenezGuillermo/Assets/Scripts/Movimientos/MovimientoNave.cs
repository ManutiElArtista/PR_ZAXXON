using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    Vector3 initPos = new Vector3(0f, 2.4f, 0f);

    [SerializeField] float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InitPos();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float despH = Input.GetAxis("Horizontal");
        float despV = Input.GetAxis("Vertical");
        float despP = Input.GetAxis("Profundidad");

        transform.Translate(Vector3.right * Time.deltaTime * speed * despH);
        transform.Translate(Vector3.up * Time.deltaTime * speed * despV);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * despP);

    }

    void InitPos ()
    {
        transform.position = initPos;
    }
}
