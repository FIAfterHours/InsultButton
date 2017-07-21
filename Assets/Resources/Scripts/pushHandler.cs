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
    IEnumerator OnMouseDown() { 
        Debug.Log("test");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/buttonpushed", typeof(Sprite)) as Sprite;

        yield return new WaitForSeconds(.2F);
        GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/button", typeof(Sprite)) as Sprite;

    }

}
