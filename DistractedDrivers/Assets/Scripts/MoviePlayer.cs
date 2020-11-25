using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class MoviePlayer : MonoBehaviour
{
    public MovieTexture movie;

    void Start()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;

        movie.Play();

    }
    void Update()
    {
        
    }
}

