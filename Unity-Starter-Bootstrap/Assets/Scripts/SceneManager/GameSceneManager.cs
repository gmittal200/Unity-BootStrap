using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameSceneManager
{
    public static void LoadScene(SceneNames scene, LoadSceneMode mode)
    {
        string sceneName = scene.ToSceneString();
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName, mode);
        }
        else
        {
            Debug.LogError($"Scene '{sceneName}' cannot be loaded. Make sure it is added to the build settings.");
        }
    }

    public static void LoadSceneAsync(SceneNames scene, LoadSceneMode mode)
    {
        string sceneName = scene.ToSceneString();
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadSceneAsync(sceneName, mode);
        }
        else
        {
            Debug.LogError($"Scene '{sceneName}' cannot be loaded asynchronously. Make sure it is added to the build settings.");
        }
    }
}
