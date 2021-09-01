using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    [SerializeField] Scene scene;
    public void ChangeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(scene.name);
    }



    void ChangeSceneAsync(string scenename)
    {


    }

    public void QuitGame()
    {

        Application.Quit();
        
    }
}
