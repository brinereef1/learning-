using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScript : MonoBehaviour
{
    [Header("Player Info")]
    public Rigidbody2D rb;
    [Range(0,100)]
    public float jump;
    public int score;
    [Header("Player UI")]
    public Text scoreTxt;
    public Color Color;
    public TMP_Text highScoreTxt;
    int val;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        val = PlayerPrefs.GetInt("HighScore", 0);
        highScoreTxt.text = val.ToString();


    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            rb.velocity = new Vector2(rb.velocity.x, jump);
                       
            if (val < score)
            {
                val = score;
                PlayerPrefs.SetInt("HighScore", score);
            }

            scoreTxt.text = score.ToString();
            highScoreTxt.text = score.ToString();
            val = PlayerPrefs.GetInt("HighScore");
            highScoreTxt.text = val.ToString();

        }
    }

    [ContextMenu("Reset")]
    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        val = PlayerPrefs.GetInt("HighScore", 0);
        highScoreTxt.text = val.ToString();


    }


}
