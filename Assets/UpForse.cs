using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpForse : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.up * 10;
    }
}
