using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    [SerializeField] GameObject objetoVariable; // Metemos dentro el objeto que queramos.
    GameObject player;
    public Velocidad velocidad;

    static public int contLife;

    [SerializeField] Image livesImage;
    [SerializeField] Sprite[] spriteArray;

    [SerializeField] ParticleSystem particleSystem;

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
        if(other.gameObject.tag == "Destructor" && contLife >= 1)
        {
            print("te has chocado");
            Destroy(other.gameObject);
            contLife--;
            livesImage.sprite = spriteArray[contLife];
        }

        if(other.gameObject.tag == "Vida" && contLife <= 2)
        {
            Destroy(other.gameObject);
            contLife++;
            livesImage.sprite = spriteArray[contLife];
        }

        else if(contLife == 0)
        {
            GameObject.Find("InstanciadorColumnas").GetComponent<InstanciadorColumna>().SendMessage("PararCorrutina"); // Asi se hace para coger el metodo de un script.
            GameObject.Find("Player").GetComponent<Puntuacion>().SendMessage("ParaNumeros");
            player = GameObject.Find("Player");
            velocidad.speedObjects = 0;
            velocidad.speed = 0;
            Instantiate(particleSystem, player.transform.position, Quaternion.identity);
            player.GetComponentInChildren<MeshRenderer>().enabled = false;
            Invoke("GameOver", 2.5f);
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(3);
    }
}
