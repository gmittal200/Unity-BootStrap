using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppLoader : MonoBehaviour
{
    public static AppLoader Instance { get; private set; } = null; 

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        /**
            1) Analytics.
            2) Debug Logging.
            3) App lifecycle events.
        **/
           
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Execute()
    {
        for (int sceneIndex = 0; sceneIndex < SceneManager.sceneCount; ++sceneIndex)
        {
            var candidate = SceneManager.GetSceneAt(sceneIndex);
            if (candidate.name == SceneNames.AppLoaderScene.ToSceneString())
                return;
        }
        GameSceneManager.LoadScene(SceneNames.AppLoaderScene, LoadSceneMode.Additive);
    }

    /// <summary>
    /// Callback sent to all game objects when the player gets or loses focus.
    /// </summary>
    /// <param name="focusStatus">The focus state of the application.</param>
    void OnApplicationFocus(bool focusStatus)
    {
        
    }

    /// <summary>
    /// Callback sent to all game objects when the player pauses.
    /// </summary>
    /// <param name="pauseStatus">The pause state of the application.</param>
    void OnApplicationPause(bool pauseStatus)
    {
        
    }

    /// <summary>
    /// Callback sent to all game objects before the application is quit.
    /// </summary>
    void OnApplicationQuit()
    {
        
    }
}
