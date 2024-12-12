using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnCollision : MonoBehaviour
{
    public string playerTag = "Player";

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "player")
        {
            EndGame();
        }
    }


    void EndGame()
    {

        Debug.Log("Game Over!");
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);

    }
}
