using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscript : MonoBehaviour
{
    Animator edAnimator;
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
      edAnimator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        { edAnimator.SetBool("isRunning", true);
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        else edAnimator.SetBool("isRunning", false);

        if (Input.GetKey(KeyCode.S))

        {
            edAnimator.SetBool("isbackWalk", true);
            transform.position -= speed * transform.forward * Time.deltaTime;
        }
        else edAnimator.SetBool("isbackWalk", false);




    }
        

}
