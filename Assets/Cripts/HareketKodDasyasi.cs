using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKodDasyasi : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] GameObject cameraObj;
    [SerializeField] float Speed = 30;
    void Start()
    {
        body = GetComponent<Rigidbody>();

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 moveTo = cameraObj.transform.forward;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * Speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 moveTo = -cameraObj.transform.forward;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 moveTo = -cameraObj.transform.right;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 moveTo = cameraObj.transform.right;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * Speed * Time.deltaTime);
        }
    }


}
