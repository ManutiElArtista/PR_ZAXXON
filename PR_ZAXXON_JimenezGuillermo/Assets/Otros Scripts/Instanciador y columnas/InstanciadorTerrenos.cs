using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorTerrenos : MonoBehaviour
{

    [SerializeField] GameObject terrenoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(terrenoPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
