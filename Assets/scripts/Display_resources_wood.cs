using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display_resources_wood : MonoBehaviour {

	public TextMeshProUGUI MadeiraTexto;
	public int Madeira=200;
	public Button Subtrai_1;
    public Button Subtrai_2;
    public Button Subtrai_3;
    public Button adiciona_1;
    public Button adiciona_2;
    public Button adiciona_3;
    
    public Button IniciaTurno;

	// Use this for initialization
	void Start () {


		Button btn = IniciaTurno;
		btn.onClick.AddListener(TaskClick);

		Button btnS1 = Subtrai_1;
		btnS1.onClick.AddListener(Subtrair1);

        Button btnS2 = Subtrai_2;
        btnS2.onClick.AddListener(Subtrair2);

        Button btnS3 = Subtrai_3;
        btnS3.onClick.AddListener(Subtrair3);

        Button btnadd1 = adiciona_1;
        btnadd1.onClick.AddListener(adicionar1);

        Button btnadd2 = adiciona_2;
        btnadd2.onClick.AddListener(adicionar2);

        Button btnadd3 = adiciona_3;
        btnadd3.onClick.AddListener(adicionar3);

        MadeiraTexto.text = Madeira.ToString ();

	}

	void Subtrair1() {

		Madeira = Madeira - 25;

	}


    void adicionar1()
    {

        Madeira = Madeira + 25;

    }

    void adicionar2()
    {

        Madeira = Madeira + 50;

    }

    void adicionar3()
    {

        Madeira = Madeira + 100;

    }

    void Subtrair2()
    {

        Madeira = Madeira - 50;

    }

    void Subtrair3()
    {

        Madeira = Madeira - 100;

    }

    //Botao clicar
    void TaskClick(){
	
		Madeira = Madeira + 100;

	}
	
	// Update is called once per frame
	void Update () {


		MadeiraTexto.text = Madeira.ToString ();


	}
}
