using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Changescene : MonoBehaviour {

	public Button mudacena;

	// Use this for initialization
	void Start () {

		Button btn = mudacena.GetComponent<Button> ();
		btn.onClick.AddListener (Taskclick);

	}

	void Taskclick()
	{
		SceneManager.LoadScene ("menuapp", LoadSceneMode.Single);

	}
	
	// Update is called once per frame
	void Update () {



	}


}
