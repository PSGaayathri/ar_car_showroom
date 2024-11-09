using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public static string currentSelectedCar = "myLamboConvert";
    void Start()
    {
        
    }

    public void quit() {
        Application.Quit();
    }

    public void changeScene(string scene) {
        SceneManager.LoadScene(scene);
    }
}
