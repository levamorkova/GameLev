using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using  UnityEngine.UI;
public class Menu : MonoBehaviour
{
    [SerializeField] GameObject manualPanel;
    [SerializeField] Button  manualButton;
   
    void Start()
    {
        if(PlayerPrefs.HasKey("isFinish")){
            manualButton.interactable = true;
        }
        
    }

   
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void ShowManual(bool open)
    {
        if (open) {
             manualPanel.SetActive(true);
        }
        else {
             manualPanel.SetActive(false);
        }
    }

}
