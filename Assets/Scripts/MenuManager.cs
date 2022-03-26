using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] Text PlayerNameInput;
   
    // Start is called before the first frame update
    void Start()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        
        DataManager.Instance.PlayerName = PlayerNameInput.text;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    } 
}

