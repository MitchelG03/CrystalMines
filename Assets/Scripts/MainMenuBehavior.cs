using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuBehavior : MonoBehaviour
{
    public GameObject mmenu;
    public Button playGame;
    public Button resetGame;
    public Button leaveGame;
    public GameDaraScriptableObject gameData;

    // Start is called before the first frame update
    void Start()
    {
        mmenu.SetActive(true);
        playGame.onClick.AddListener(() => PlayGame());
        resetGame.onClick.AddListener(() => ResetGame());
        leaveGame.onClick.AddListener(() => LeaveGame());
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Village");
    }
    private void ResetGame()
    {
        gameData.money = 0;
        gameData.pickax = 1;
        gameData.speed = 7;
        gameData.rotateSpeed = 10;
        gameData.howMuchMoney = 1;
    }
    private void LeaveGame()
    {
        Application.Quit();
        Debug.Log("Imagine the Game closed");
    }
}
