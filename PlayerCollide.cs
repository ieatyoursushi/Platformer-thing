using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class PlayerCollide : MonoBehaviour {
    public static int attemps = 0;
    public Text text;
    public AudioSource Death;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Player")
        {
            Debug.Log("Died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            attemps++;
            text.text = "Attempts: " + attemps.ToString();
            Death.Play();
        }

    }
    private void Start()
    {
        Death.Pause();
    }
    private void Update()
    {
        
        text.text = "Attempts: " + attemps.ToString();
    }
}
