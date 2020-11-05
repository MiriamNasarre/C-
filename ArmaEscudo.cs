using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaEscudo : MonoBehaviour
{
	GameObject manoDerecha;
	public GameObject Arma;
	public GameObject Escudo;
	GameObject manoIzquierda;
	string personaje,arma,escudo;
	float posX,posY,posZ;
    // Start is called before the first frame update
	public GameObject [] hueso;
    void Start()
    {
		personaje = gameObject.name;
		Debug.Log(personaje);
		
		manoDerecha=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_26/Bone_28/Bone_30/Bone_32");
		Debug.Log(manoDerecha);
		
		manoIzquierda=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_25/Bone_27/Bone_29");
		Debug.Log(manoIzquierda);
		
		Arma=GameObject.FindWithTag("Arma");
		Arma.transform.Rotate(0.0f, 240.0f, 270.0f, Space.Self);
		Arma.transform.localPosition=new Vector3(-0.0623f,-0.004f,-0.0103f);
		Debug.Log(Arma);
		
		
       Escudo=GameObject.FindWithTag("Escudo");
	   Escudo.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
	   Escudo.transform.localPosition=new Vector3(-0.1202363f,0.092f,-0.004f);
	   Debug.Log(Escudo);
	   
	   for (int j=0;j<15;j++){
	  	 for(int i=41;i<=69;i+=2){
	   		if(i==41 | i==47 |i==53 | i==59 | i==65){
	   			hueso[j]=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_26/Bone_28/Bone_30/Bone_32"+"/Bone_"+i);
			}
			
			if(i==43|i==49|i==55|i==61| i==67){
					hueso[j]=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_26/Bone_28/Bone_30/Bone_32"+"/Bone_"+(i-2)+"/Bone_"+i);
			}
			
			
			if(i==45|i==51|i==57|i==63|i==69){
				hueso[j]=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_26/Bone_28/Bone_30/Bone_32"+"/Bone_"+(i-4)+"/Bone_"+(i-2)+"/Bone_"+i);
			}
			
			
			if (i==59|i==65){
				hueso[j]=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_26/Bone_28/Bone_30/Bone_32/Bone_34"+"/Bone_"+i);
			}
			
			if(i==61 |i==67){
				hueso[j]=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_26/Bone_28/Bone_30/Bone_32/Bone_34"+"/Bone_"+(i-2)+"/Bone_"+i);
			}
			
			if(i==63 |i==69){
				hueso[j]=GameObject.Find(personaje+"/Armature/Bone_0/Bone_1/Bone_2/Bone_15/Bone_16/Bone_26/Bone_28/Bone_30/Bone_32/Bone_34"+"/Bone_"+(i-4)+"/Bone_"+(i-2)+"/Bone_"+i);
			}
			
	   }
	   }
	   
	   
	   
	   
	  
	   
	   
	   
	   
	   
	   
	   
    }




    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnAnimatorIK(){
		 hueso[0].transform.localRotation=Quaternion.Euler(-180.0f,-40.0f,20.0f);
	   hueso[2].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-85.0f);
	   hueso[3].transform.localRotation=Quaternion.Euler(-97.20699f,-56.19598f,-20.0f);
	   hueso[4].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-80.0f);
	   hueso[5].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-60.0f);
	   hueso[6].transform.localRotation=Quaternion.Euler(-91.99999f,-1.525879e-05f,-80.0f);
	   hueso[7].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-90.0f);
	   hueso[8].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-80.0f);
	   hueso[9].transform.localRotation=Quaternion.Euler(2.0f,-6.0f,-80.0f);
	   hueso[10].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-20.0f);
	   hueso[11].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-80.0f);
	   hueso[12].transform.localRotation=Quaternion.Euler(3.789f,-12.066f,-70.0f);
	   hueso[13].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-20.0f);
	   hueso[14].transform.localRotation=Quaternion.Euler(0.0f,0.0f,-80.0f);
	}
}
