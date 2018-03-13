using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public GameObject[] audioSources; // array of sources for each type of sound
    public AudioClip[,] clips; // 2D array of audio clips. First param is type of sound; second is clip number.
    public AudioClip[] oneDClip; // 1 dimentional clip array to edit the 2d one in inspector

	// Use this for initialization
	void Start () {
        int depth = (oneDClip.Length) / (audioSources.Length);
        clips = new AudioClip[audioSources.Length, depth];
        for (int x = 0; x < audioSources.Length; x++) {
            for (int y = 0; y < clips.GetLength(1); y++) {
                clips[x, y] = oneDClip[x*clips.GetLength(1) + y];
            }
        }
        for (int i = 0; i < audioSources.Length; i++)
        {
            audioSources[i].GetComponent<AudioSource>().loop = true;
            audioSources[i].GetComponent<AudioSource>().Play();
        }
    }
	
	// Update is called once per frame
	void Update () {
        

    }

    // sets clip being played.
    public void setClip(int source, int clip) {
        audioSources[source].GetComponent<AudioSource>().clip = clips[source, clip];
    }
}

