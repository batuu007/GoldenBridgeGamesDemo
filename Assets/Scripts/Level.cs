using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
   public void LoadGame()
    {
        ResetGame();
        SceneManager.LoadScene("GamePlay");
    }
    public void LoadGameWin()
    {
        StartCoroutine(DelayGameWin());
    }
    IEnumerator DelayGameWin()
    {     
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("WinScene");
    }
    public void LoadGameLoss()
    {
        SceneManager.LoadScene("LoseScene");
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
