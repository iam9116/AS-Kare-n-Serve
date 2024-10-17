using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum EScene : int
{
    MainMenu = 0,
    TimedMode,
    Controls,
    Credits,
    GameOver,
    GameWin,
    FemaleGameScene,
    BaristaChoose,
    GameScene
}

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.sceneLoaded.Add(OnSceneLoaded);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }

    public void LoadScene()
    {
       
        SceneManager.LoadScene(1);
    }

    public void LoadScene(int gender)
    {
        SceneManager.LoadScene(7);
        GameObject obj = GameObject.Find("PlayerSpawner");
        PlayerSpawner playerSpawner = obj.GetComponent<PlayerSpawner>();

        playerSpawner.SpawnPlayer(gender);
    }

    public void LoadOtherScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadOtherOtherScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadOtherOtherOtherScene()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadOtherOtherOtherOtherScene()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadOtherOtherOtherOtherOtherScene()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadOtherOtherOtherOtherOtherOtherScene()
    {
        SceneManager.LoadScene(8);
    }

    public void BaristaEnabler()
    {

    }
}
