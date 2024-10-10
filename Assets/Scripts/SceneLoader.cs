using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
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
}
