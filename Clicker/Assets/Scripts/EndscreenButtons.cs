using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndscreenButtons : MonoBehaviour
{
    Action SwitchToMenuScene;

    private void Awake()
    {
        SwitchToMenuScene = GameManager.Get().SwitchToMenuScene;
    }
    public void OnClickBackToMenuBtn()
	{
		SwitchToMenuScene();
	}
}
