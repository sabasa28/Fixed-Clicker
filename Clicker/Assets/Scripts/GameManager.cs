using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Get()
    {
        return instance;
    }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void OnWin()
    {
        SwitchToEndscreen();
    }
    public void SwitchToMenuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void SwitchToGameplayScene()
    {
        SceneManager.LoadScene(1);
    }
    void SwitchToEndscreen()
    { 
		SceneManager.LoadScene(2);
    }
    public void CloseGame()
    {
        Debug.Log("Game Closed.");
        Debug.Break();
    }
}
