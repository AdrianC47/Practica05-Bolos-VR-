using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Metodo : MonoBehaviour
{

    // Use this for initialization
    public Text Puntaje;
    public HighScore highSc;

    void Start()
    {

    }




    void Update()
    {
        Puntaje.text = "Ha obtenido " + highSc.highScore.ToString();

    }

}
