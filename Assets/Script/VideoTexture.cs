﻿using UnityEngine;
using System.Collections;

public class VideoTexture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
