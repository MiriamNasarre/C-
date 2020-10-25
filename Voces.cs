using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voces : MonoBehaviour
{
	AudioSource voz;
	bool selec=false;
    // Start is called before the first frame update
    void Start()
    {
		selec=false;
		
    }

    // Update is called once per frame
    void Update()
    {
		selec=false;
		if(Input.GetKeyUp(KeyCode.Return)) {
			selec=true;
		}else{
			selec=false;
		}
		
		if(selec==true){
			voz=GetComponent<AudioSource>();
			if(voz!=null){
				voz.Play();
			}
			
		}
	
        
    }
}
