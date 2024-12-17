using System.Collections;
using System.Collections.Generic;

public enum SceneNames
{
    AppLoaderScene
}

public static class SceneNamesExtensions
{
    public static string ToSceneString(this SceneNames scene)
    {
        return scene.ToString();
    }
}
