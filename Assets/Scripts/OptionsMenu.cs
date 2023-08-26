using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public static float Volume = 1;

    public static void SetVolume(float volume) {
        Volume = volume;
    }
    
    void Update() {
        Debug.Log(Volume);
    }
}
