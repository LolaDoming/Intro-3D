using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant : MonoBehaviour
{
    public GameObject cuboPreFab;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    public void instanciarCubo()
    {
        Instantiate(cuboPreFab);
    }
}
