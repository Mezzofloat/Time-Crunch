using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAudio : MonoBehaviour
{
    private AudioSource music;
    // Start is called before the first frame update
    void Awake() => music = GetComponent<AudioSource>();
    void Start() {
        music.volume = OptionsMenu.Volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
