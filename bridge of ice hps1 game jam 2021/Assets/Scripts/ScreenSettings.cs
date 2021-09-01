using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSettings : MonoBehaviour
{
    static public ScreenSettings instance;

    public bool isPaused = false;

    public GameObject pauseVign;
    public GameObject retryBTN;

    public List<AudioSource> sounds;
    

    void PauseSound()
    {
        for(int i=0;i<sounds.Count;i++)
        {
            sounds[i].Pause();
        }
    }

    void UnPauseSound()
    {
        for (int i = 0; i < sounds.Count; i++)
        {
            sounds[i].UnPause();
        }
    }


    void Start()
    {
        instance = this;

        retryBTN.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }


        if (isPaused)
        {
            Time.timeScale = 0;

            pauseVign.SetActive(true);
            PauseSound();

            if (DrownedRestart.instance.gotDrownd == true)
                retryBTN.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;

            pauseVign.SetActive(false);
            UnPauseSound();
            retryBTN.SetActive(false);
        }

        Cursor.visible = isPaused;
    }

}
