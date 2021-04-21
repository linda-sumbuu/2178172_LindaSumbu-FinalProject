using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressF : MonoBehaviour
{
   

    void Start()
    {
        
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int LevelIndex)
    {


        yield return new WaitForSeconds(0);

        SceneManager.LoadScene(LevelIndex);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            LoadNextLevel();
        }
    }
}
