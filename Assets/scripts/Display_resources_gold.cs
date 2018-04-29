using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display_resources_gold : MonoBehaviour {

	public Text OuroTexto;
	public int Ouro=200;
	public Button IniciaTurno;
	public Button Subtrai_1;


	// Use this for initialization
	void Start () {


		Button btn = IniciaTurno;
		btn.onClick.AddListener(TaskClick);

		Button btnS1 = Subtrai_1;
		btnS1.onClick.AddListener(Subtrair1);


		OuroTexto.text = Ouro.ToString ();

	}

	//Botao clicar
	void TaskClick(){

		Ouro = Ouro + 20;

	}


	void Subtrair1() {

		Ouro = Ouro - 200;
	
	}

	// Update is called once per frame
	void Update () {

		OuroTexto.text = Ouro.ToString ();

	}




}
