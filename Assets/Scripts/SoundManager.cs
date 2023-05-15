using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource music;
    [SerializeField]
    private AudioSource button;
    [SerializeField]
    private AudioSource jump;

    private static SoundManager instance;

    public static SoundManager Instance
    {
        get
        {
            if (instance != null)
            {
                return instance;
            }

            instance = FindObjectOfType<SoundManager>();

            if (instance != null)
            {
                return instance;
            }

            GameObject soundManager = new GameObject("[GameManager]");
            instance = soundManager.AddComponent<SoundManager>();
            DontDestroyOnLoad(instance.gameObject);
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playMusic();
    }    

    public void playMusic()
    {
        music.Play();
    }

    public void playButtonSFX()
    {
        button.Play();
    }

    public void playJumpSFX() 
    {
        jump.Play();
    }
}
