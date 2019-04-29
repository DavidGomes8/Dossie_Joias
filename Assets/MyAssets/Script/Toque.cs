using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toque : MonoBehaviour
{
    public float distancia = 1000000f;

    public GameObject[] joias = new GameObject[12];

    public AudioClip[] sons = new AudioClip[6];

    private AudioSource output;

    private void Start()
    {
        output = GetComponent<AudioSource>();
    }

    private void Update()
    {
        toque();
    }

    private void toque()
    {
        #region Space

        if (Input.GetMouseButtonDown(0) && joias[0].gameObject.GetComponent<Collider>().enabled)
        {
            if (joias[0].activeInHierarchy == false)
            {
                joias[0].gameObject.SetActive(true);
                joias[1].gameObject.SetActive(false);
            }
            else if (joias[0].activeInHierarchy == true)
            {
                joias[0].gameObject.SetActive(false);
                joias[1].gameObject.SetActive(true);
            }
        }

        if (joias[0].gameObject.GetComponent<Collider>().enabled)
        {
            output.clip = sons[0];
            output.Play();
        }

        #endregion Space

        #region Time

        if (Input.GetMouseButtonDown(0) && joias[2].gameObject.GetComponent<Collider>().enabled)
        {
            if (joias[2].gameObject.GetComponent<Collider>().enabled)
            {
                bool frente = true;
                if (Roda.velocidade == 50)
                {
                    Roda.velocidade = 1000;
                }

                if (frente && Roda.velocidade == 1000)
                {
                    Roda.velocidade = -1000;
                    frente = false;
                }
                else if (!frente && Roda.velocidade == -1000)
                {
                    Roda.velocidade = 1000;
                    frente = true;
                }
            }
        }
        if (!joias[2].gameObject.GetComponent<Collider>().enabled)
        {
            Roda.velocidade = 50;
        }

        if (joias[2].gameObject.GetComponent<Collider>().enabled)
        {
            output.clip = sons[1];
            output.Play();
        }

        #endregion Time

        #region Soul

        if (Input.GetMouseButtonDown(0) && joias[4].gameObject.GetComponent<Collider>().enabled)
        {
        }

        if (joias[4].gameObject.GetComponent<Collider>().enabled)
        {
            output.clip = sons[2];
            output.Play();
        }

        #endregion Soul

        #region Reality

        if (Input.GetMouseButtonDown(0) && joias[6].gameObject.GetComponent<Collider>().enabled)
        {
            if (joias[6].activeInHierarchy == false)
            {
                joias[6].gameObject.SetActive(true);
                joias[7].gameObject.SetActive(false);
            }
            else if (joias[6].activeInHierarchy == true)
            {
                joias[6].gameObject.SetActive(false);
                joias[7].gameObject.SetActive(true);
            }

            joias[6].transform.Translate(Vector3.back);
        }

        if (joias[6].gameObject.GetComponent<Collider>().enabled)
        {
            output.clip = sons[3];
            output.Play();
        }

        #endregion Reality

        #region Power

        if (Input.GetMouseButtonDown(0) && joias[8].gameObject.GetComponent<Collider>().enabled)
        {
            if (joias[8].activeInHierarchy == false)
            {
                joias[8].gameObject.SetActive(true);
                joias[9].gameObject.SetActive(false);
            }
            else if (joias[8].activeInHierarchy == true)
            {
                joias[8].gameObject.SetActive(false);
                joias[9].gameObject.SetActive(true);
            }
        }

        if (joias[8].gameObject.GetComponent<Collider>().enabled)
        {
            output.clip = sons[4];
            output.Play();
        }

        #endregion Power

        #region Mind

        if (Input.GetMouseButtonDown(0) && joias[10].gameObject.GetComponent<Collider>().enabled)
        {
            if (joias[10].activeInHierarchy == false)
            {
                joias[10].gameObject.SetActive(true);
                joias[11].gameObject.SetActive(false);
            }
            else if (joias[10].activeInHierarchy == true)
            {
                joias[10].gameObject.SetActive(false);
                joias[11].gameObject.SetActive(true);
            }
        }

        if (joias[10].gameObject.GetComponent<Collider>().enabled)
        {
            output.clip = sons[5];
            output.Play();
        }

        #endregion Mind
    }
}