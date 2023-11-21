using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void LoadQuestion()
    {
        SceneManager.LoadScene("Scenes/sceneQuestion");
    }

    public void LoadQuestionA()
    {
        SceneManager.LoadScene("Scenes/sceneQuestionA");
    }

    public void LoadQuestionB()
    {
        SceneManager.LoadScene("Scenes/sceneQuestionB");
    }

    public void Loadsetting()
    {
        SceneManager.LoadScene("Scenes/sceneLobby");
    }
    
}
