using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScene : MonoBehaviour
{
	public void SwitchToMenuScene()
	{
		SceneManager.LoadScene(0);
	}
}
