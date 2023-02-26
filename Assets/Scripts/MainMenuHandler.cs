using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetPlayerName()
    {
        PlayerHandle.Instance.playerName = playerName.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
