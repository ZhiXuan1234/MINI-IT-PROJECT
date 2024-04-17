using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSoundManager : MonoBehaviour
{
    public static CoinSoundManager instance;
    public AudioSource coinssource;
    public AudioClip CoinSound;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
