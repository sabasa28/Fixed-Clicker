using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
	public GameplayButton[] button;
	public TMP_Text scoreText;
    public SubtractionText subtractionText;
    public Action Win;

	public int score = 0;

    int scoreToWin = 10000;

	void Start()
    {
        Win = GameManager.Get().OnWin;
        StartCoroutine(SubtractFromScore());
        for (int i = 0; i < button.Length; i++)
        {
			button[i].AddScore = AddToScore;
        }
    }

	public void AddToScore(int toAdd)
	{
		score += toAdd;
        UpdateScoreText();
        if (score >= scoreToWin)
        {
            score = 0;
            Win();
        }

        for (int i = 0; i < button.Length; i++)
        {
            if (!button[i].gameObject.activeSelf && button[i].scoreToActivate <= score)
            {
                button[i].gameObject.SetActive(true);
            }
        }
    }

    IEnumerator SubtractFromScore()
    {
        while (true)
        {
            if (score > 0)
            {
                int aux= 1+ (int)(score * 0.2f);
                score -= aux;
                UpdateSubtractionText(aux);
                UpdateScoreText();
            }
            yield return new WaitForSeconds(1);
        }
    }

    void UpdateScoreText()
    { 
        scoreText.text = "Score:" + score;
    }

    void UpdateSubtractionText(int subtraction)
    { 
        subtractionText.tmp.text = "-" + subtraction + "!";
        subtractionText.GetComponent<SubtractionText>().alpha = 1.0f;
    }
}
