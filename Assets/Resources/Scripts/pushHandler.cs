using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushHandler : MonoBehaviour {

    int i = 0;

    public AudioSource[] insults;
    public AudioSource[] SFWInsults;

    public AudioClip[] testinsult;

// Use this for initialization
void Start () {
        Debug.Log("test");
        testinsult = Resources.LoadAll<AudioClip>("SFWSounds/");
        Debug.Log(testinsult[1]);
    }

    // Update is called once per frame
    void Update () {
    }

    void switchToNSFW ()
    {
        testinsult = Resources.LoadAll<AudioClip>("NSFWSounds/");

    }

    void switchToSFW()
    {
        testinsult = Resources.LoadAll<AudioClip>("SFWSounds/");

    }

    void OnMouseDown() {
        AudioSource audio = GetComponent<AudioSource>();

        int clipvalue = (int)(Random.value * testinsult.Length);
            print(clipvalue);
            audio.clip = testinsult[clipvalue];
            

        Debug.Log(testinsult);

        audio.Play();

        GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/buttonpushed", typeof(Sprite)) as Sprite;

        //yield return new WaitForSeconds(.2F);
        //GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/button", typeof(Sprite)) as Sprite;
    }

    void OnMouseUp(){
                GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/button", typeof(Sprite)) as Sprite;
    }
}  






