using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Lava : MonoBehaviour
{
    [SerializeField]private string Cena;
    [SerializeField]private Image ImagemMorte;
    [SerializeField]private Text TextoMorte;
    [SerializeField]private Image BotaoMorte1;
    [SerializeField]private Image BotaoMorte2;
    [SerializeField]private Text TextoBotaoMorte1;
    [SerializeField]private Text TextoBotaoMorte2;
    [SerializeField]private Pedra scriptPedra;
    [SerializeField]private Nuvem scriptNuvem;

    private void Start(){
        ImagemMorte.enabled = false;
        TextoMorte.enabled = false;
        BotaoMorte1.enabled = false;
        BotaoMorte2.enabled = false;
        TextoBotaoMorte1.enabled = false;
        TextoBotaoMorte2.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D lavareset){
        if(lavareset.gameObject.tag == "PlayerCloud"){
            SceneManager.LoadScene(Cena);
        }
    }
    public void heatdestroy(){
        Destroy(gameObject);
    } 
}
