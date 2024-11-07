using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour
{
    int HEALTH = 100;
    int damage = 25;
    Rigidbody rb;
    // Start is called before the first frame update
    internal void ExplosionAt(Vector3 position, float explosionRadius, float explosionStrength)
    {
        HEALTH -= damage;
        print("Ouch!!! my health is now " + HEALTH.ToString());
        rb.AddExplosionForce(explosionStrength, position, explosionRadius);
    }
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
