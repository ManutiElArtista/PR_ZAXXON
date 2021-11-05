using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    [SerializeField] GameObject objetoVariable; // Metemos dentro el objeto que queramos.
    public Velocidad velocidad;

    static public int contLife;

    [SerializeField] Image livesImage;
    [SerializeField] Sprite[] spriteArray;

    // Start is called before the first frame update
    void Start()
    {

        objetoVariable = GameObject.Find("Variable");
        velocidad = objetoVariable.GetComponent<Velocidad>();

        contLife = 3;
        livesImage.sprite = spriteArray[contLife];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Destructor" && contLife > 1)
        {
            print("te has chocado");
            contLife--;
            livesImage.sprite = spriteArray[contLife];
        }

        else
        {
            velocidad.speedObjects = 0;
            velocidad.speed = 0;
            print("Game Over");
        }
    }
}
