using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }
    private AudioSource source;
    private AudioSource musicSource;

    private void Awake()
    {
       instance = this;
       source = GetComponent<AudioSource>();
       musicSource = transform.GetChild(0).GetComponent<AudioSource>();

    }

    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    
    }

    public void ChangeSoundVolume(float _change)
    {
        //Get Base Volume
        float baseVolume = 1;
        
        //Get initial value of volume and change it
        float currentVolume = PlayerPrefs.GetFloat("soundVolume"); //Load last saved sound volume from player prefs 
        currentVolume += _change;

        //Check if we reached the max or min value
        if (currentVolume > 1)
            currentVolume = 0;
        else if (currentVolume < 0)
            currentVolume = 1;

        //Assign final value
        float finalVolume = currentVolume * baseVolume;
        source.volume = finalVolume;

        //Save final value to player prefs
        PlayerPrefs.SetFloat("soundVolume", currentVolume);
    
    }

    public void ChangeMusicVolume(float _change)
    {
        //Get Base Volume
        float baseVolume = 0.3f;

        //Get initial value of volume and change it
        float currentVolume = PlayerPrefs.GetFloat("musicVolume"); //Load last saved sound volume from player prefs 
        currentVolume += _change;

        //Check if we reached the max or min value
        if (currentVolume > 1)
            currentVolume = 0;
        else if (currentVolume < 0)
            currentVolume = 1;

        //Assign final value
        float finalVolume = currentVolume * baseVolume;
        musicSource.volume = finalVolume;

        //Save final value to player prefs
        PlayerPrefs.SetFloat("musicVolume", currentVolume);
    }
}
