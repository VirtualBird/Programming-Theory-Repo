using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenStart : MonoBehaviour
{ 
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
