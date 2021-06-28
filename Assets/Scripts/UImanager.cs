using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public GameObject pnlMainMenu;
    public GameObject pnlSetting;
    public GameObject pnlJackPot;
    public GameObject pnlAvatars;
    public GameObject pnlHeroUpdate;
    public GameObject currentPanel;
    void Start()
    {
        currentPanel = pnlMainMenu;
    }

    
    void Update()
    {
        
    }
    public void OnSettingBtnClicked()
    {
        //currentPanel.SetActive(false);
        currentPanel = pnlSetting;
        currentPanel.SetActive(true);
    }
    public void OnJackPotBtnClicked()
    {
        currentPanel.SetActive(false);
        currentPanel = pnlJackPot;
        currentPanel.SetActive(true);
    }
    public void OnCloseBtnClicked()
    {
        currentPanel.SetActive(false);
        currentPanel = pnlMainMenu;
        currentPanel.SetActive(true);
    }


}
