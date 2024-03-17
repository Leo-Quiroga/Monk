using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public GameObject startPanel, pausePanel;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        PanelStartOn();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();

        }
    }
    public void PanelStartOn()
    {
        startPanel.SetActive(true);
        Time.timeScale = 0;

    }
    public void PanelStartOff()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1;
        //AudioManager.instance.PlayMusic(AudioManager.instance.randomMusic);
    }

    public void PanelPauseOn()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;

    }
    public void PanelPauseOff()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void PauseUnpause()
    {
        if (pausePanel.activeInHierarchy)
        {

            pausePanel.SetActive(false);
            Time.timeScale = 1f;


        }
        else
        {
            pausePanel.SetActive(true);

            Time.timeScale = 0f;

        }  
    }
}
