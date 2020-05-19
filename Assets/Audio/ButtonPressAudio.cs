using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressAudio : MonoBehaviour {

    public AudioSource button_press;

    public void PressButton()
    {
        button_press.Play();
    }
}
