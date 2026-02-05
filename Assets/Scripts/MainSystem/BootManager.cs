using System;
using Cysharp.Threading.Tasks;
using MainSystem.Scene;

namespace MainSystem 
{
public class BootManager 
{
    ISceneLoader _sceneLoader;
    public BootManager(ISceneLoader sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }
    public void Initialize()
    {
        // ゲームに必要な初期化処理



        _sceneLoader.LoadScene(SceneType.MainMenuScene).Forget();
    }
}
}