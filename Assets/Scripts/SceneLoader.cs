using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
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
    private int selectedGender;
    private bool gameInitialized = false;


    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        selectedGender = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (gameInitialized == false && scene.name == "GameScene" && scene.isLoaded == true)
        {
            GameObject obj = GameObject.Find("PlayerSpawner");
            PlayerSpawner playerSpawner = obj.GetComponent<PlayerSpawner>();
            playerSpawner.SpawnPlayer(selectedGender);

            gameInitialized = true;
        }
    }

    public void LoadScene(int gender)
    {
        selectedGender = gender;
        SceneManager.LoadScene(7);
    }

    public void LoadSceneByNumber(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
