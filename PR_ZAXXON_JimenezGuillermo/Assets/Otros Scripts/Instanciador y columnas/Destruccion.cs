using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{

    float destruccion = -5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destruccionColumna();
    }

    void destruccionColumna()
    {
        if (transform.position.z <= destruccion)
        {
            Destroy(gameObject);
        }
    }
}
