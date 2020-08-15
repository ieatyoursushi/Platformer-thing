using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour {


    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void LevelScreen()
    {
        SceneManager.LoadScene("LevelScreen");
    }
    public void MainScreen()
    {
        SceneManager.LoadScene("MainScreen");
    }
    public void Level01()
    {
        SceneManager.LoadScene("Level1");

    }
    public void Level02()
    {
        SceneManager.LoadScene("level2");

    }
    public void Level03()
    {
        SceneManager.LoadScene("level3");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
