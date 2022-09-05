using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuMorte : MonoBehaviour
{
    [SerializeField]private Image ImagemMorte;
    [SerializeField]private Text TextoMorte;
    [SerializeField]private Image BotaoMorte1;
    [SerializeField]private Image BotaoMorte2;
    [SerializeField]private Text TextoBotaoMorte1;
    [SerializeField]private Text TextoBotaoMorte2;
    [SerializeField]private GameObject Pedra;
    [SerializeField]private GameObject Nuvem;
    [SerializeField]private string Cena;

    public void MenuButton(){
        SceneManager.LoadScene(Cena);
    }

    public void RestartButton(){
        Instantiate(Pedra, new Vector2(-10f, -3f), Quaternion.identity);
        Instantiate(Nuvem, new Vector2(-9f, -3f), Quaternion.identity);
        ImagemMorte.enabled = false;
        TextoMorte.enabled = false;
        BotaoMorte1.enabled = false;
        BotaoMorte2.enabled = false;
        TextoBotaoMorte1.enabled = false;
        TextoBotaoMorte2.enabled = false;
    }


}
