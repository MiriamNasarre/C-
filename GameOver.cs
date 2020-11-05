using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
	int vidaJ1, vidaJ2;
	bool muerto=false;
	bool bloqueo=false;
	bool golpe=false;
	GameObject arma1,arma2;
    // Start is called before the first frame update
    void Start()
    {
	
        vidaJ1=250;
		vidaJ2=250;
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaJ1==0| vidaJ2==0)
			muerto=true;
		
		
		if(muerto){
			//cargar menú2 con tres botones repetir, seleccionar personaje y salir.
			
		}
		
		if(arma1 && golpe && !bloqueo){
			vidaJ1-=10;
		}
		
		if(arma2 && golpe && !bloqueo){
			vidaJ2-=10;
		}
    }
}
