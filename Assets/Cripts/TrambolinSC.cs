using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrambolinSC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 YeniHiz;
        YeniHiz.x = collision.gameObject.GetComponent<Rigidbody>().velocity.x;
        YeniHiz.y = 10f;
        YeniHiz.z = collision.gameObject.GetComponent<Rigidbody>().velocity.z;

        Debug.Log(YeniHiz);

        collision.gameObject.GetComponent<Rigidbody>().velocity = YeniHiz;
    }
}
