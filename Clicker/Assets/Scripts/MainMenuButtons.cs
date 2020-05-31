using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons: MonoBehaviour
{
	public GameObject Menu;
	public GameObject Credits;
	Action SwitchToGameplayScene;
	Action CloseGame;

	private void Start()
    {
		SwitchToGameplayScene = GameManager.Get().SwitchToGameplayScene;
		CloseGame = GameManager.Get().CloseGame;
	}

    public void OnClickStartGameBtn()
	{
		SwitchToGameplayScene();
	}
	public void OnClickCreditsBtn()
	{
		Menu.SetActive(false);
		Credits.SetActive(true);
	}
	public void OnClickQuitBtn()
	{
		CloseGame();
	}
	public void OnClickBackToMenuBtn()
	{
		Menu.SetActive(true);
		Credits.SetActive(false);
	}
}
