using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    public void reset()
    {
        SceneManager.LoadScene(0);
        audioManager.resetSound();
    }
    // public void quit()
    // {
    //     Application.Quit();
    // }
}
