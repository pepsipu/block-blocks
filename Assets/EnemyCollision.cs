using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyCollision : MonoBehaviour
{
    public Text score;
    public Text gameOver;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "shield")
        {
            Invoke("SlowDestroy", .2f);
        } else if (other.gameObject.name == "player")
        {
            score.text = "0";
            gameOver.gameObject.SetActive(true);
            Invoke("Restart", .5f);
        }
    }
    void SlowDestroy()
    {
        Destroy(gameObject);
        score.text = (Convert.ToInt32(score.text) + 1).ToString();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
