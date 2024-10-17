using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myheroscript : MonoBehaviour
{
    float runningSpead = 3f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))



        if(Input.GetKey(KeyCode.W))
            { transform.position += runningSpead*transform.forward* Time.deltaTime; }

        if (Input.GetKey(KeyCode.S))
        { transform.position -= runningSpead*transform.forward * Time.deltaTime; }
    
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 45 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Space))
        { transform.position += runningSpead * transform.up * Time.deltaTime; }
    }
}
