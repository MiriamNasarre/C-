using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personajes : MonoBehaviour
{
   public Image selector,selector2;
   int x;
   int y;
   int x2=0;
   int y2=0;
   int xant;
   int xant2;
   bool seleccionado;
    bool seleccionado2;
	public GameObject j1,j2;
	public GameObject[] personajes;
	Image s2;
	Text text;
  
 public GameObject[] botones;

 
   void Start(){
   	for(int x=0;x<botones.Length;x++){
		//Debug.Log(x+" "+botones[x]);
	}
	personajes[x].SetActive(false);
	seleccionado=false;
	seleccionado2=false;
	j1=GameObject.Find("j1");
	j2=GameObject.Find("j2");
	s2=GameObject.Find("s2").GetComponent<Image>();
	s2.enabled=false;
	text=GameObject.Find("Canvas/Text").GetComponent<Text>();
   }
   
   void jugador(GameObject [] objetos,GameObject contenedor){
   	if(seleccionado==false){
	if(Input.GetKeyUp(KeyCode.Return)){
		seleccionado=true;	
		Debug.Log(seleccionado);
		
	}
	
	if(Input.GetKeyUp(KeyCode.O)){
			xant=x;
			x+=42;
			Debug.Log(x);
			for(int y=0;y<42;y++){
				botones[y].SetActive(false);
				
			}
			for (int x=42;x<70;x++){
				botones[x].SetActive(true);
			}
			text.text="2/2";
			
			}
			
			
	if(Input.GetKeyUp(KeyCode.C)){
			x=xant;
			Debug.Log(x);
			for(int y=0;y<42;y++){
				botones[y].SetActive(true);
			}
			
			for (int x=42;x<70;x++){
				botones[x].SetActive(false);
			}
			text.text="1/2";
	}


			
	
	   if(Input.GetKeyUp(KeyCode.RightArrow)) {	
						if (x>=0 && x<13) {
							x+=1;
							Debug.Log("X der: "+x);
							selector.transform.position+=new Vector3(75,0,0);
						}else if (x>13 && x<27){
							x+=1;
							Debug.Log("X der: "+x);
							selector.transform.position+=new Vector3(75,0,0);	
						}else if (x>27 && x<42){
							x+=1;
							Debug.Log("X der: "+x);
							selector.transform.position+=new Vector3(75,0,0);
						}else if(x>41 && x<55){
							x+=1;
							Debug.Log("X der: "+x);
							selector.transform.position+=new Vector3(75,0,0);
						}else if(x>55 && x<70){
							x+=1;
							Debug.Log("X der: "+x);
							selector.transform.position+=new Vector3(75,0,0);
						}

	
		}
		if(Input.GetKeyUp(KeyCode.LeftArrow)) {
			if(x>0 && x<14){	
					x-=1;
					Debug.Log("X izq: "+x);
					selector.transform.position-=new Vector3(75,0,0);	

			}else if(x>14 && x<28){
				x-=1;
					Debug.Log("X izq: "+x);
					selector.transform.position-=new Vector3(75,0,0);	
			}else if(x>28 && x<42){
				x-=1;
					Debug.Log("X izq: "+x);
					selector.transform.position-=new Vector3(75,0,0);	
			}else if(x>42 && x<56){
				x-=1;
					Debug.Log("X izq: "+x);
					selector.transform.position-=new Vector3(75,0,0);	
			}	
					
		}
		if(Input.GetKeyUp(KeyCode.DownArrow)) {
					if(y<2){
						if(y==0) {
							y+=1;
							// Debug.Log("Y: "+y);
							selector.transform.position-=new Vector3(0,75,0);	

							}else if (y==1 && x<42){
								y+=1;
								selector.transform.position-=new Vector3(0,75,0);
							}
							
						}
	  			   // Debug.Log("Y: "+y);

		}
		if(Input.GetKeyUp(KeyCode.UpArrow)) {
							if(y>0){
								if(y<3){
									y-=1;
								//	Debug.Log("Y: "+y);
									selector.transform.position+=new Vector3(0,75,0);

									
								}
							}
		}
	
	
	if(seleccionado==true){
		Debug.Log(y);
		if(y==1){
		   personajes[x+14].SetActive(true);
			j1=personajes[x+14];
				Debug.Log(j1);
		}else if(y==2){
		   personajes[x+28].SetActive(true);
			j1=personajes[x+28];
				Debug.Log(j1);
		}else if (y==0){
			 personajes[x].SetActive(true);
	   		j1=personajes[x];
		}
		for(int y=56;y<70;y++){
				botones[y].SetActive(true);
			}
		
	}
	
	
	
		}
   }
   
   
     
   
   void jugador2(GameObject [] objetos,GameObject contenedor){
   	if(Input.GetKeyUp(KeyCode.Space)){
			seleccionado2=true;
			//Debug.Log(x2);
		
		}
		
		
		
		if(Input.GetKeyUp(KeyCode.O)){
			xant2=x2;
			x2+=42;
			//Debug.Log(x2);
			for(int y2=0;y2<42;y2++){
				botones[y2].SetActive(false);
			}
			
			for (int x2=42;x2<70;x2++){
				botones[x2].SetActive(true);
			}
			text.text="2/2";
			
			}
			
			
	if(Input.GetKeyUp(KeyCode.C)){
			x2=xant2;
			for(int y2=0;y2<42;y2++){
				botones[y2].SetActive(true);
			}
			
			for (int x2=42;x2<70;x2++){
				botones[x2].SetActive(false);
			}
			text.text="1/2";
	}


	
   if(seleccionado2==true){
   	Debug.Log(y2);
	Debug.Log(x2);
		if(y2==0){
		  j2.transform.position=new Vector3(311,-61,+240);
		    j2=personajes[x2];
	   		personajes[x2].SetActive(true);
			personajes[x2].transform.position+= new Vector3(0,-100,0);
		}else if(y2==1){
		   j2=personajes[x2+14];	  
			j2.transform.position=new Vector3(311,-61,+240);
		   personajes[x2+14].SetActive(true);
		   personajes[x2+14].transform.position+= new Vector3(0,-100,0);
				Debug.Log(j2);
		}else if(y2==2){
			j2=personajes[x2+28];		  
		j2.transform.position=new Vector3(311,-61,+240);
		personajes[x2+28].SetActive(true);
		personajes[x2+28].transform.position+= new Vector3(0,-100,0);
			
		}
		for(int y2=56;y2<70;y2++){
				botones[y2].SetActive(true);
			}
		
	}
	
	
	
	
	
	if(seleccionado2==false && seleccionado==true){
		s2.enabled=true;
	   if(Input.GetKeyUp(KeyCode.RightArrow)) {	
						if (x2>=0 && x2<13) {
							x2+=1;
							Debug.Log("X der: "+x);
							selector2.transform.position+=new Vector3(75,0,0);
						}else if (x2>13 && x2<27){
							x2+=1;
							Debug.Log("X der: "+x);
							selector2.transform.position+=new Vector3(75,0,0);	
						}else if (x2>27 && x2<42){
							x2+=1;
							Debug.Log("X der: "+x);
							selector2.transform.position+=new Vector3(75,0,0);
						}else if(x2>41 && x2<55){
							x2+=1;
							Debug.Log("X der: "+x);
							selector2.transform.position+=new Vector3(75,0,0);
						}else if(x2>55 && x2<69){
							x2+=1;
							Debug.Log("X der: "+x);
							selector2.transform.position+=new Vector3(75,0,0);
						}

	
		}
		if(Input.GetKeyUp(KeyCode.LeftArrow)) {
			if(x2>0 && x2<14){	
					x2-=1;
					Debug.Log("X izq: "+x);
					selector2.transform.position-=new Vector3(75,0,0);	

			}else if(x2>14 && x2<28){
				x2-=1;
					Debug.Log("X izq: "+x);
					selector2.transform.position-=new Vector3(75,0,0);	
			}else if(x2>28 && x2<42){
				x2-=1;
					Debug.Log("X izq: "+x);
					selector2.transform.position-=new Vector3(75,0,0);	
			}else if(x2>42 && x2<56){
				x2-=1;
					Debug.Log("X izq: "+x);
					selector2.transform.position-=new Vector3(75,0,0);	
			}else{
				x2-=1;
					Debug.Log("X izq: "+x);
					selector2.transform.position-=new Vector3(75,0,0);	
			}	
					
		}
		if(Input.GetKeyUp(KeyCode.DownArrow)) {
					if(y2<2){
						if(y2==0) {
							y2+=1;
							// Debug.Log("Y: "+y);
							selector2.transform.position-=new Vector3(0,75,0);	

							}else if (y2==1 && x2<42){
								y2+=1;
								selector2.transform.position-=new Vector3(0,75,0);
							}
							
						}
	  			   // Debug.Log("Y: "+y);

		}
		if(Input.GetKeyUp(KeyCode.UpArrow)) {
							if(y2>0){
								if(y2<3){
									y2-=1;
								//	Debug.Log("Y: "+y);
									selector2.transform.position+=new Vector3(0,75,0);

									
								}
							}
		}
		}
		}

   
 
   void Update(){
   
		jugador(personajes,j1);
		
		jugador2(personajes,j2);

	
		}
		}

		
		





 


