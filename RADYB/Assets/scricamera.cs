using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class scricamera : MonoBehaviour
{
    public GameObject knifeCloneTemplete;
    float speed = 3;
    float sprintSpeed = 6;

    private float currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
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
            Instantiate(knifeCloneTemplete, transform.position, transform.rotation);
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
    }
    }
