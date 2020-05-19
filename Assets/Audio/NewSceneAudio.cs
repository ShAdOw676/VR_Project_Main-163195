using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSceneAudio : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
