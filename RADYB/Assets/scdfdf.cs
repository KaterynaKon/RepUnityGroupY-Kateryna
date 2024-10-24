using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scdfdf : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(10*transform.forward,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
