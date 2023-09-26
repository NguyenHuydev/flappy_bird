using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

    int m_score;
    public Text textScore;
    public GameObject panelgame;
    public Text txtScoreEnd;
    //public
    bool endGame =false;
    // Start is called before the first frame update

    void Start()
    {
        Time.timeScale = 0f;
        m_score = 0;
        textScore.text = "Sowocore:" + m_score;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetAxisRaw("Vertical") !=0 && endGame == false) {
            Time.timeScale = 1;
        }*/
        if (Input.touchCount>0 && endGame == false)
        {
            Time.timeScale = 1;
        }

    }
    //SceneManager.LoadScene(" Start");
    // SceneManager
 
    public void EndGame()
    {
        Time.timeScale = 0f;
        if(panelgame != null)
        {
            panelgame.SetActive(true);
            txtScoreEnd.text = "Your Score:"+ m_score;
        }
        
        Debug.Log("da goi ham endgame");
        endGame = true;
    }

    public void IncrementScore()
    {
        m_score++;
        textScore.text = "Score:" + m_score;
    }

    public void StartGame()
    {
        Debug.Log("da bawts dau game");
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene("StartScene");
        //
    }
}
