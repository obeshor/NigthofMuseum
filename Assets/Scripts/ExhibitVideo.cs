using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playMovie()
    {
        Handheld.PlayFullScreenMovie("Unity_3d_Tutorial.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
    }

}
