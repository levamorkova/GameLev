using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    
     public void Reload()
    {
        SceneManager.LoadScene(1);
    }
    public void FinishQuest()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("isFinish",1);
    }

}
