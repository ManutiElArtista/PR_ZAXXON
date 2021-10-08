using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] Transform instObject; // Le indicamos la posicion desde la cual va a salir el objeto.
    [SerializeField]  GameObject prefabBullet; // Le indicamos que objeto va a salir desde la posicion.

    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("mouse 0"))
        {

            StartCoroutine("Bala");

        }
    }

    IEnumerator Bala()
    {
        GameObject newBullet;
        
        newBullet = Instantiate(prefabBullet, instObject.position, instObject.rotation);

        yield return new WaitForSeconds(speed);
    }
}
