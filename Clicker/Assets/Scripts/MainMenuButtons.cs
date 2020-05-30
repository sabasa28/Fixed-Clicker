using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons: MonoBehaviour
{
	public GameObject Menu;
	public GameObject Credits;

	public void SwitchToGameplayScene()
	{
		SceneManager.LoadScene(1);
	}
	public void ShowCredits()
	{
		Menu.SetActive(false);
		Credits.SetActive(true);
	}
	public void CloseGame()
	{
		Debug.Log("Game Closed.");
		Debug.Break();
	}
	public void ShowMenu()
	{
		Menu.SetActive(true);
		Credits.SetActive(false);
	}
}
