using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    // Componente renderer.
    Renderer rend;

    // Vector de desplazamiento del plano.
    [SerializeField] Vector2 despl;

    // Script donde tengo las velocidades.
    Velocidad velocidad;

    // Velocidad del plano.
    [SerializeField] float speedScroll;

    // Start is called before the first frame update
    void Start()
    {
        // Cogemos el componente Renderer.
        rend = GetComponent<Renderer>();

        // Indicamos el script que queremos coger.
        GameObject variable = GameObject.Find("Variable");
        velocidad = variable.GetComponent<Velocidad>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ponemos velocidad.
        speedScroll = velocidad.speedObjects / 10;

        // Se tiene que mover en funcion del tiempo que ha transcurrido.
        float offset = Time.time * speedScroll;

        // Vector 2 para desplazar en X y en Y.
        despl = new Vector2(0, -offset);

        // Decimos al material que se desplace.
        rend.material.SetTextureOffset("_MainTex", despl);
        rend.material.SetTextureOffset("_BumpMap", despl);
    }
}
