using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display_resources : MonoBehaviour {

	public TextMeshProUGUI Texto;
	public int unidade=200;
    int contador = 0;


	// Use this for initialization
	void Start () {

	    Texto.text = unidade.ToString ();

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


    // Botoes que adicionam e tiram recursos

    public void s25() {

        StartCoroutine("s25_w");

	}

    IEnumerator s25_w()
    {
        contador = 0;

        while (contador < 25)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade - 5;
            contador = contador + 5;
        }
    }


    public void s50()
    {

        StartCoroutine("s50_w");

    }

    IEnumerator s50_w()
    {
        contador = 0;

        while (contador < 50)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade - 5;
            contador = contador + 5;
        }
    }


    public void s75()
    {

        StartCoroutine("s75_w");

    }

    IEnumerator s75_w()
    {
        contador = 0;

        while (contador < 75)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade - 5;
            contador = contador + 5;
        }
    }


    public void a25()
    {

        StartCoroutine("a25_w");

    }

    IEnumerator a25_w()
    {
        contador = 0;

        while (contador < 25)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade + 5;
            contador = contador + 5;
        }
    }

    public void a50()
    {

        StartCoroutine("a50_w");

    }

    IEnumerator a50_w()
    {
        contador = 0;

        while (contador < 50)
        {
            yield return new WaitForSeconds(0.0001f);

            unidade = unidade + 5;
            contador = contador + 5;
        }
    }


    public void a75()
    {

        StartCoroutine("a75_w");

    }

    IEnumerator a75_w()
    {
        contador = 0;

        while (contador < 75)
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
