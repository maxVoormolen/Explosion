using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject TNT;
    public GameObject ParticleSystem0;
    public GameObject ParticleSystem1;
    public GameObject ParticleSystem2;
    public GameObject ParticleSystem3;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            TNT.SetActive(false);
            ParticleSystem0.SetActive(true);
            ParticleSystem1.SetActive(true);
            ParticleSystem2.SetActive(true);
            ParticleSystem3.SetActive(true);
        }
        if (Input.GetKey(KeyCode.R))
        {
            TNT.SetActive(true);
            ParticleSystem0.SetActive(false);
            ParticleSystem1.SetActive(false);
            ParticleSystem2.SetActive(false);
            ParticleSystem3.SetActive(false);
        }
    }
}
