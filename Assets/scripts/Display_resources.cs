using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display_resources : MonoBehaviour {

    public GameObject sun_moon;
	public TextMeshProUGUI Texto;
	public int unidade;
    int contador = 0;


	// Use this for initialization
	void Start () {

	    Texto.text = unidade.ToString ();

	}


    public void start_turno_mortos()
    {
        StartCoroutine("start_turno_mortos_anim");
        
    }

    IEnumerator start_turno_mortos_anim()
    {

        contador = 0;
        while( contador < 18 )
        {
            yield return new WaitForSeconds(0.00001f);
            sun_moon.transform.Rotate(0, 0, 10);
            contador += 1;
        }
    }


	//Botao começo turno madeira
	public void start_turno_madeira(){

        StartCoroutine("start_turno_madeira_w");

	}
    

    IEnumerator start_turno_madeira_w()
    {
        contador = 0;

        while (contador < 100)
        {

            yield return new WaitForSeconds(0.00001f);
            unidade = unidade + 10;
            contador = contador + 10;
        }

    }


    //Botao começo turno madeira
    public void start_turno_ouro()
    {

        StartCoroutine("start_turno_ouro_w");

    }

    IEnumerator start_turno_ouro_w()
    {
        contador = 0;

        while (contador < 50)
        {

            yield return new WaitForSeconds(0.00001f);
            unidade = unidade + 10;
            contador = contador + 10;
        }

    }

    // metodo com parametro pra adicionar mortos

    public void adicionar_m(int adicao)
    {
        StartCoroutine(adicionar_m_animacao(adicao));
    }

    IEnumerator adicionar_m_animacao(int adicao)
    {
        contador = 0;

        while (contador < adicao)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade + 1;
            contador = contador + 1;
        }
    }
    // metodo com parametro pra subtrair mortos

    public void subtrair_m(int subtracao)
    {
        StartCoroutine(subtrair_m_animacao(subtracao));
    }

    IEnumerator subtrair_m_animacao(int subtracao)
    {

        contador = 0;

        while (contador < subtracao)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade - 1;
            contador = contador + 1;
        }
    }

    // metodo com parametro pra subtrair

    public void subtrair(int subtracao)
    {
        StartCoroutine(subtrair_animacao(subtracao));
    }

    IEnumerator subtrair_animacao(int subtracao)
    {

        contador = 0;

        while (contador < subtracao)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade - 5;
            contador = contador + 5;
        }
    }

    // metodo com parametro pra adicionar

    public void adicionar(int adicao)
    {
        StartCoroutine(adicionar_animacao(adicao));
    }

    IEnumerator adicionar_animacao(int adicao)
    {
        contador = 0;

        while (contador < adicao)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade + 5;
            contador = contador + 5;
        }
    }

    // Update is called once per frame
    void Update () {

		Texto.text = unidade.ToString ();

	}




}
