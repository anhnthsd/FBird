using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.Script
{
    public class GameController : MonoBehaviour
    {
        public static GameController ins;
        public int score = 0;

        public bool isStart = false;
        public Text txtScore;
        public GameObject panel;
        public Text txtResultScore;
        public GameObject btnStart;

        private void Awake()
        {
            ins = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            panel.SetActive(false);
            Time.timeScale = 0;
        }

        public void onBtnStartClick()
        {
            isStart = true;
            btnStart.SetActive(false);
            Time.timeScale = 1;
        }

        public void ResetGame()
        {
            SceneManager.LoadScene(0);
        }

        public void PlusScore()
        {
            score++;
            txtScore.text = "Score: " + score;
        }

        public void GameOver()
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            txtResultScore.text = "Your score:\n" + score;
        }
    }
}