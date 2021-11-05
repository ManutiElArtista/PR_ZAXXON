using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube : MonoBehaviour
{
    
    [SerializeField] GameObject objetoPlayer;
    MovimientoYRapidez velocidad;

    // Start is called before the first frame update
    void Start()
    {
        objetoPlayer = GameObject.Find("Player");
        velocidad = objetoPlayer.GetComponent<MovimientoYRapidez>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Para que cuando el jugador se meta dentro de la nube se reduzca su velocidad.
    {
        if(other.gameObject.tag == "Player")
        {
            velocidad.speed /= 6;
            print("Velocidad disminuida");
        }
    }

    private void OnTriggerExit(Collider other) // Para que cuando el jugador salga de la nube se aumente la velocidad.
    {
        if(other.gameObject.tag == "Player")
        {
            velocidad.speed *= 6;
            print("Velocidad aumentada");
        }
    }
}
