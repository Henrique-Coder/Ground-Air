using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    [SerializeField]private Image ImagemMorte;
    [SerializeField]private Text TextoMorte;
    [SerializeField]private Image BotaoMorte1;
    [SerializeField]private Image BotaoMorte2;
    [SerializeField]private Text TextoBotaoMorte1;
    [SerializeField]private Text TextoBotaoMorte2;
    [SerializeField]private Pedra scriptPedra;
    [SerializeField]private Nuvem scriptNuvem;

    

    void Start(){
        ImagemMorte.enabled = false;
        TextoMorte.enabled = false;
        BotaoMorte1.enabled = false;
        BotaoMorte2.enabled = false;
        TextoBotaoMorte1.enabled = false;
        TextoBotaoMorte2.enabled = false;

    }
    void OnTriggerEnter2D(Collider2D playerdeath){
        if(playerdeath.gameObject.tag == "PlayerCloud" || playerdeath.gameObject.tag == "PlayerGround"){
            ImagemMorte.enabled = true;
            TextoMorte.enabled = true;
            BotaoMorte1.enabled = true;
            BotaoMorte2.enabled = true;
            TextoBotaoMorte1.enabled = true;
            TextoBotaoMorte2.enabled = true;
            scriptNuvem.DestroirNuvem();
            scriptPedra.DestroirPedra();
        }
    }
}
