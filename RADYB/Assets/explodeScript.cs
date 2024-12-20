using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeScript : MonoBehaviour
{
    Rigidbody rb;
    float ExplosionRadius = 10;
    float ExplosionStrangth = 2000;
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
    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimCollider = Physics.OverlapSphere(transform.position, ExplosionRadius);
        foreach (Collider collider in allVictimCollider)
        {
            scricamera player = collider.GetComponent<scricamera>();
            if (player != null)
            {
                // player.ExplosionAt(transform.position, ExplosionRadius, ExplosionStrangth);

            }
            else
            {
                person personVictim = collider.GetComponent<person>();
                if (personVictim != null)
                {
                    personVictim.ExplosionAt(transform.position, ExplosionRadius, ExplosionStrangth);

                }
                else
                {
                    Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
                    if (rigidbody != null)
                    {
                        rigidbody.AddExplosionForce(ExplosionStrangth, transform.position, ExplosionRadius);
                    }
                }
            }
        }
        Destroy(gameObject);
    }

}
