using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toque : MonoBehaviour
{

    public float distancia = 1000000f;

    public GameObject[] joias = new GameObject[6];

    void Start()
    {
        
    }

    void Update()
    {
        toque();
        
    }

    private void toque()
    {
        if (Input.GetMouseButton(0) && joias[0].gameObject.GetComponent<Collider>().enabled)
        {
            Vector3
        }

        if (Input.GetMouseButton(0) && joias[1].gameObject.GetComponent<Collider>().enabled)
        {
            
        }

        if (Input.GetMouseButton(0) && joias[2].gameObject.GetComponent<Collider>().enabled)
        {
            
        }

        if (Input.GetMouseButton(0) && joias[3].gameObject.GetComponent<Collider>().enabled)
        {
            
        }

        if (Input.GetMouseButton(0) && joias[4].gameObject.GetComponent<Collider>().enabled)
        {
            
        }

        if (Input.GetMouseButton(0) && joias[5].gameObject.GetComponent<Collider>().enabled)
        {
            
        }
    }
}
