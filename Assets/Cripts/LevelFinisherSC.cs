using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisherSC : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("LevelGecildi !!");
            DataBase.SaveData();
            int levelIndex = SceneManager.GetActiveScene().buildIndex;
            Debug.Log(levelIndex);
            levelIndex = levelIndex +1;

            SceneManager.LoadScene(levelIndex);
        }
        
    }
}
