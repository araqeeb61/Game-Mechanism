using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   
    // Method to load a scene by name
    void Start()
    {
    }

    void Update()
    {

    }

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadSceneAsync("Level1");
    }

    public void CloseGame()
    {
        Application.Quit();
    }

   
  
   
}
