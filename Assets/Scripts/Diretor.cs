using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{

    public GameObject imagemGameOver;
    [SerializeField]

    private Aviao aviao;

    



    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
        Debug.Log("Finalizar Jogo");
    }

    public void ReiniciarJogo()
    {


        aviao.Reiniciar();
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        DestruirObstaculos();
        Debug.Log("Reiniciou");

        //destruir obstaculos

    }
    private void DestruirObstaculos()
    {
        Obstaculos[] obstaculosEncontrados = GameObject.FindObjectsOfType<Obstaculos>();
        foreach(Obstaculos obstaculoAtual in obstaculosEncontrados)
        {
            obstaculoAtual.Destruir();
        }
    }

       void Start()
    {
        aviao = GameObject.FindObjectOfType<Aviao>();
    }

   
    void Update()
    {
        
    }
}
