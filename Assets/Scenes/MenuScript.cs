using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
    }
}
