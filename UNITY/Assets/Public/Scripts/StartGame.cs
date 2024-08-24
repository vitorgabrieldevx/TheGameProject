using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string NomeDoLevelDeJogo; 

    public void Jogar()
    {
        SceneManager.LoadScene(NomeDoLevelDeJogo); 
    }
}