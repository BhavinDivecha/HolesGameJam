using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSounds : MonoBehaviour
{
    [SerializeField]
    AudioClip jumpSounds, ColideSounds;
    [SerializeField]
    AudioSource source;
    public static GameSounds Instance;
    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            source = GetComponent<AudioSource>();
            ChangeMusic();
            //source.enabled = false;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    void ChangeMusic()
    {
        string str = PlayerPrefs.GetString("Music", "On");
        if (str == "On")
        {
            source.mute = false;
        }
        if (str == "Off")
        {
            source.mute = true;
        }
    }
    public void PlayJumpSound(int i)
    {
        source.enabled = true;
        switch (i)
        {
            case 1:
                source.PlayOneShot(ColideSounds);
                break;
            case 2:
                source.PlayOneShot(jumpSounds);
                break;
        }
       
    }
    public AudioSource Source()
    {
        return source;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
