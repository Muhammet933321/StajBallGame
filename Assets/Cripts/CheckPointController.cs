using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        DataBase.SpawnPosition = transform.position;
        Debug.Log(DataBase.SpawnPosition);
    }
}
