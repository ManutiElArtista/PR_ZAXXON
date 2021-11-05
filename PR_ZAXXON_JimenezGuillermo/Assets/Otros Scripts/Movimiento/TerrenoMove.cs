using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoMove : MonoBehaviour
{

    Velocidad velocidad;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = GameObject.Find("InitGame").GetComponent<Velocidad>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float speed = velocidad.speed;
    }
}
