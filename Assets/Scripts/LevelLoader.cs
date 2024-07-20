using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        StartCoroutine(LoadLevelDelayed(levelName));
    }

    IEnumerator LoadLevelDelayed(string levelName)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelName);
    }
}