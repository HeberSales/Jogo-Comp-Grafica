using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private int scoreValue = 0;

    private bool collised;

    public Score score;

    public GameWinScreen GameWinScreen;

    // Start is called before the first frame update
    void Start()
    {
        collised = false;
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = "Score: " + scoreValue;
        scoreText.text = scoreValue.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name.Equals("Shuriken"))
        {
            collised = true;
            collision.gameObject.SetActive(false);
        }
            if (collision.gameObject.CompareTag("Shuriken"))
        {
            scoreValue += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("END"))
        {
            SceneManager.LoadScene("GameWin");
        }
    }
}
