using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roda : MonoBehaviour
{
    public static float velocidade = 50f;

    private void Start()
    {
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * velocidade * Time.deltaTime);
    }
}