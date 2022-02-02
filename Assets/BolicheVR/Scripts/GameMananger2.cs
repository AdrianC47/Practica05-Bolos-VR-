using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMananger2 : MonoBehaviour
{

    //Primero moveremos la bola
    // Manejaremos puntos
    // Majeramos turnos 
    // Use this for initialization
    public GameObject ball;
    int score = 0;
    int turnCounter = 0;
    GameObject[] pins;
    public Text scoreUI;

    Vector3[] positions;

    public HighScore high;
    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("Pin");
        positions = new Vector3[pins.Length];

        for (int i = 0; i < pins.Length; i++)
        {
            positions[i] = pins[i].transform.position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        MoveBall();
        if (Input.GetMouseButtonDown(1) || ball.transform.position.y < -5)
        {
            CountPinsDown();
            turnCounter++;

            ResetBall();

            if (turnCounter == 2)
            {
                ResetPins();
                if (score > 80)
                {
                    Debug.Log("Ganaste ");
                    high.highScore = score;
                    SceneManager.LoadScene("Victoria2");
                }
                else
                {
                    SceneManager.LoadScene("Derrota2");
                    high.highScore = score;
                }
            }
        }
    }




    void MoveBall()
    {
        Vector3 position = ball.transform.position;
        position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -7.227f, -5.722f);
        ball.transform.position = position;
        //		ball.transform.Translate(Vector3.right * Input.GetAxis("Horizontal")* Time.deltaTime);
    }

    void CountPinsDown()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            if (pins[i].transform.eulerAngles.z > 5 && pins[i].transform.eulerAngles.z < 355 &&
                pins[i].activeSelf)
            {
                score = score + 10;
                pins[i].SetActive(false);
            }

        }
        scoreUI.text = "Ha obtenido " + score.ToString();
    }

    void ResetPins()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            pins[i].SetActive(true);
            pins[i].transform.position = positions[i];
            pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            pins[i].transform.rotation = Quaternion.identity;
        }


    }

    void ResetBall()
    {
        ball.transform.position = new Vector3(-6.391f, 0.71648f, -4.549291f);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ball.transform.rotation = Quaternion.identity;
    }

}
