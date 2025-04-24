using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    void Start()
    {
        DataBase.LoadData();
    }

    public void Level1Click()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2Click()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3Click()
    {
        SceneManager.LoadScene("Level3");
    }

}
