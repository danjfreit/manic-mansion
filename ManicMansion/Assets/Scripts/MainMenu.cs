﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UI = UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject ButtonPanel;

    public GameObject CreditsPanel;

    public EventSystem _eventSystem;

    public GameObject CreditsBackButton;
    public GameObject MainMenuPlayButton;

    public void Play()
    {
        SceneManager.LoadScene("TheScene");
    }
    
    public void ShowButtons()
    {
        ButtonPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        
        _eventSystem.SetSelectedGameObject(MainMenuPlayButton);
    }

    public void ShowCredits()
    {
        ButtonPanel.SetActive(false);
        CreditsPanel.SetActive(true);

        _eventSystem.SetSelectedGameObject(CreditsBackButton);
    }
}
