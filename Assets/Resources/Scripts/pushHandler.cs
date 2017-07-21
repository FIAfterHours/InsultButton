using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushHandler : MonoBehaviour {




    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {


		
	}
    void OnMouseDown() { 
        Debug.Log("test");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();



        Debug.Log(GetComponent<SpriteRenderer>().sprite);
        GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/buttonpushed", typeof(Sprite)) as Sprite; 
        Debug.Log(GetComponent<SpriteRenderer>().sprite);   
    }
}
