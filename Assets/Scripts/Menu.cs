using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string Cena;

    public void PlayButton(){
        SceneManager.LoadScene(Cena);
    }

    public void OptionsButton(){
        SceneManager.LoadScene(Cena);
    }

    public void ExitButton(){
        Application.Quit();
    }
}
