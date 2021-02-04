using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("LoadingScreen")]
    [SerializeField] private GameObject LoadingScreen;                              //the gameobject for the loading screen
    [SerializeField] private Slider LoadingBar;                                     //the Slider in the LoadingScreen GameObject

    [SerializeField] private GameObject HowScreen;
    private bool activity = false;
    public void LevelLoader(int SceneIndex)                                         //the function that makes you able to load diffrent scene with loading screen
    {
        StartCoroutine(AsyncLoad(SceneIndex));                                      //decided by chosen Int which scene you want
        Time.timeScale = 1f;
    }
    public void Restart()                                         
    {
        StartCoroutine(AsyncLoad(SceneManager.GetActiveScene().buildIndex));        //Load current scene      
        Time.timeScale = 1f;
    }
    public void HowtoPlay()
    {
        activity = !activity;
        HowScreen.SetActive(activity);
    }
    IEnumerator AsyncLoad(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);         //the operator to check the process of your loading screen

        LoadingScreen.SetActive(true);

        while (!operation.isDone)                                                   //Loop until the process is done
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);              //makes the progress go 100% instead of 99%


            Debug.Log(operation.progress);
            LoadingBar.value = progress;                                            //translate the progress to the slider bar          

            yield return null;
        }
    }


    public void QuitGame()                                                          //Quit the application completely
    {
        Application.Quit();
        Debug.Log("you Quit");
    }
}
