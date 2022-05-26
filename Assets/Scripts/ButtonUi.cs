using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUi : MonoBehaviour
{
    [SerializeField] private string LoadLevel = "WormLevel";
    public void NewGameButton()
    {
        SceneManager.LoadScene(LoadLevel);
    }
}
