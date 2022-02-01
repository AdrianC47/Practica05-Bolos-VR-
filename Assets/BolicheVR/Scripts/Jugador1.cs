using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jugador1 : MonoBehaviour {

	public void IrAEscena (string nombreEscena){
		Debug.Log("Bienvenido Jugador1");
		SceneManager.LoadScene(nombreEscena);
	}
}
