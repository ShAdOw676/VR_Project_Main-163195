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

        GUIStyle colorRed = new GUIStyle();

        colorRed.normal.textColor = Color.red;
        colorRed.fontSize = 30;

        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points, colorRed);
    }
}
