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

    public void ClickPlayButton()
    {
        SceneManager.LoadScene("Level01");
    }

}
