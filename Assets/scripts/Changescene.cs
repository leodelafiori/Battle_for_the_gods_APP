using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour {


	public void troca_cena(string cena)
    {

        SceneManager.LoadScene(cena);

    }


}
