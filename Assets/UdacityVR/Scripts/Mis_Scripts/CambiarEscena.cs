using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiarEscena : MonoBehaviour {

	public void IrAEscena (string nombreEscena){
		Debug.Log("Mi metodo fue llamado !! animo");
		SceneManager.LoadScene(nombreEscena);
	}
}
