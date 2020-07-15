using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringScript : MonoBehaviour {
    public int points = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);

        GUIStyle colorGreen = new GUIStyle();

        colorGreen.normal.textColor = Color.green;
        colorGreen.fontSize = 30;

        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points, colorGreen);
    }
}
