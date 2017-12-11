using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamestart : MonoBehaviour {

     public Button startButton;

	// Use this for initialization
	void Start () {
        Button StartButton = startButton.GetComponent<Button>();
        StartButton.onClick.AddListener(presstart);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void presstart()
    {
        SceneManager.LoadScene("demoscene", LoadSceneMode.Single);
    }
}
