using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AltinToplamaMekanigi : MonoBehaviour
{
    [SerializeField] Vector3 donmeYonu;
    [SerializeField] TextMeshProUGUI goldTxt;
    private void Start()
    {
        goldTxt.text = $"Gold = {DataBase.AltinSayisi}";
    }
    void Update()
    {
        transform.Rotate(donmeYonu);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            DataBase.AltinSayisi++;
            goldTxt.text = $"Gold = {DataBase.AltinSayisi}";
            Debug.Log(DataBase.AltinSayisi);
        }
        
    }

}
