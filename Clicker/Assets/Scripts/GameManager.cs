using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool won = false;
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
    private void Start()
    {
    }

    public void OnWin()
    {
        SwitchToEndscreen();
    }
    void SwitchToEndscreen()
    { 
		SceneManager.LoadScene(2);
    }
}
