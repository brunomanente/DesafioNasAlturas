using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculo : MonoBehaviour
{

    [SerializeField]

    private float tempoParaGerar = 3f;
    [SerializeField]

    private GameObject manualDeInstrucoes;

    private float cronometro = 0f;


    private void Awake()
    {
        cronometro = tempoParaGerar;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;
        if(cronometro <= 0)
        {
            //Debug.Log("3 segundos");
            //Debug.Log(Quaternion.identity);
            GameObject.Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}
