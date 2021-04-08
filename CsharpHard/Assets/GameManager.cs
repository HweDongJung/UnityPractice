using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnPlayerDead()
    {
        Invoke("Restart", 5f);
    
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
    }

}
