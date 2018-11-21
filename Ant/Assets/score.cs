using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;
    public Text GameOver;
    public Text re;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;


    // Use this for initialization
    void Start()
    {
        scoreText.enabled = true;
        GameOver.enabled = false;
        re.enabled = false;
        hiScoreText.enabled = true;
        if (PlayerPrefs.GetFloat("HighScore") != null)
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ant") != null)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;

            if (scoreCount > hiScoreCount)
            {
                hiScoreCount = Mathf.Round(scoreCount * 100f) / 100f;
                PlayerPrefs.SetFloat("HighScore", hiScoreCount);
            }

            scoreText.text = "Time Alive: " + Mathf.Round(scoreCount * 100f) / 100f;
            hiScoreText.text = "High Score: " + hiScoreCount;
        }
        else {
            GameOver.enabled = true;
            re.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                Application.LoadLevel("Ant");
            }
        }
    }
}
