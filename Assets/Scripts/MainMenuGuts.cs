using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuGuts : MonoBehaviour
{
   public void loadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void loadSceneByIndex(int index) {
        SceneManager.LoadScene(index);
    }
    

    public void quitGame(){
        Debug.Log("Quitting. . .");
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    public void loadNextScene(){
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if(nextSceneIndex > SceneManager.sceneCount){
            nextSceneIndex = 1;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
