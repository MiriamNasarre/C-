using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour

{
public AudioClip [] canciones=new AudioClip[136];
public AudioSource cancion;
int aleatorio;
string nombre;

    // Start is called before the first frame update
    void Start()
    {
		cancion=GetComponent<AudioSource>();
		cancion.clip=canciones[Random.Range(0,canciones.Length-1)];
		cancion.Play();
    }

    // Update is called once per frame
    void Update()
    {
		if(!cancion.isPlaying){
			cancion.clip=canciones[Random.Range(0,canciones.Length-1)];	
        	cancion.Play();
		}
    }
}
