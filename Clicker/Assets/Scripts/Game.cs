using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
	public GameObject click01;
	public GameObject click02;
	public GameObject click03;

	int score = 0;

	public TMP_Text t;

	public GameObject click04;

	void Start()
    {
        
    }

    void Update()
    {
	    t.text = "Gold:" + score;

	    if (score > 10)
	    {
		    click01.SetActive(true);
	    }
		if (score > 50)
	    {
		    click02.SetActive(true);
		}
		if (score > 100)
		{
			click03.SetActive(true);
		}
	    if (score > 200)
	    {
		    click04.SetActive(true);
	    }
	}

	public void Click01()
	{
		coso.sc += 1;
	}

	public void Click02()
	{
		coso.sc += 2;
	}

	public void Click03()
	{
		coso.sc += 5;
	}

	public void Click04()
	{
		coso.sc += 10;
	}

	public void Click05()
	{
		coso.sc += 50;
	}
}
