using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenericInteractiveObject : MonoBehaviour, IActivatable
{
    public Button winButton;
    public Text winText;
    public GameObject winState;

    public static bool hasWon = false;

    [SerializeField]
    private string nameText = "Generic Activated Object";

    private void Awake()
    {
        winState = GameObject.Find("VictoryState");
        Button WinButton = winButton.GetComponent<Button>();
        WinButton.onClick.AddListener(Endgame);
    }

    private void Start()
    {
        winState.SetActive(false);
    }

    public void Endgame()
    { Application.Quit(); }

    public string NameText
    {
        get
        {
            return nameText;
        }
    }



    public void DoActivate()
    {
        winState.SetActive(true);
        hasWon = true;
    }

}
