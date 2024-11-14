using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class scricamera : MonoBehaviour
{
    public GameObject knifeCloneTemplete;
    public Camera mainCamera;
    public float jumpForce = 5f;

    float speed = 3;
    float sprintSpeed = 6;
    //float jumpForce = 5f;
    float jumpSpeed = 15f;
    Rigidbody rb;

    private float currentSpeed;
   // private bool isGrounded = true;
    //private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        currentSpeed = Input.GetKey(KeyCode.LeftShift) ?
            sprintSpeed : speed;
       

        if (Input.GetKey(KeyCode.W))

        {
            Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDir.Normalize();
            transform.position += fpsMovementDir * currentSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))

        {
            Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDir.Normalize();
            transform.position -= currentSpeed * fpsMovementDir * Time.deltaTime;

        }

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);
        transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(knifeCloneTemplete, transform.position + 2* transform.forward, transform.rotation);
        }
        if (Input.GetKey(KeyCode.D))

        {
            Vector3 fpsMovementDir = new Vector3(-transform.right.x, 0, -transform.right.z);
            fpsMovementDir.Normalize();
            transform.position -= currentSpeed * fpsMovementDir * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))

        {
            Vector3 fpsMovementDir = new Vector3(transform.right.x, 0, transform.right.z);
            fpsMovementDir.Normalize();
            transform.position -= currentSpeed * fpsMovementDir * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 fpsMovementDir =Vector3.up;
            
            fpsMovementDir.Normalize();
            rb.AddForce(jumpForce*Vector3.up,ForceMode.Impulse);
        }
    }
    }
