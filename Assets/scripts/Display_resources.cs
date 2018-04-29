using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display_resources : MonoBehaviour {

	public Text MadeiraTexto;
	public int Madeira=200;
	public Button Subtrai_1;

	public Button IniciaTurno;

	// Use this for initialization
	void Start () {


		Button btn = IniciaTurno;
		btn.onClick.AddListener(TaskClick);

		Button btnS1 = Subtrai_1;
		btnS1.onClick.AddListener(Subtrair1);

		MadeiraTexto.text = Madeira.ToString ();

	}

	void Subtrair1() {

		Madeira = Madeira - 200;

	}

	//Botao clicar
	void TaskClick(){
	
		Madeira = Madeira + 20;

	}
	
	// Update is called once per frame
	void Update () {


		MadeiraTexto.text = Madeira.ToString ();


	}
}
