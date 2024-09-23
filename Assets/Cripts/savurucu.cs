using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savurucu : MonoBehaviour
{
    [SerializeField] int force = 10;
    private void OnCollisionEnter(Collision collision)
    {

        Vector3 characterPos = collision.transform.position;
        Vector3 obstaclePos = transform.position;    
        Vector3 lastSpeed = (characterPos - obstaclePos).normalized * force;
        collision.gameObject.GetComponent<Rigidbody>().velocity = lastSpeed;
    }
}
