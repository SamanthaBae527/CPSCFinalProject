using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    private int score;

    public AudioClip gemCollectClip;
    void Update()
    {
        scoreText.text = score.ToString();

    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Gem")
        {
            AudioSource.PlayClipAtPoint(gemCollectClip, transform.position);
            Destroy(target.gameObject);
            score++;
        }
        if (target.tag == "Potion")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
