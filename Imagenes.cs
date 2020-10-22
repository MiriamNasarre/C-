using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagenes : MonoBehaviour
{
public Image derecha;
public Image izquierda;
public Sprite[] imagen=new Sprite[426];
object[] imagenes;
int num;
int num2;

void Start()
{
	num = UnityEngine.Random.Range(0,imagen.Length-1);
	num2 = UnityEngine.Random.Range(0,imagen.Length-1);
	while(num==num2){
		num= UnityEngine.Random.Range(0,imagen.Length-1);
	}
	derecha.sprite=imagen[num];
	izquierda.sprite=imagen[num2];
	changeImage();
}


void Update(){
	if(derecha.transform.position.y>=800 && izquierda.transform.position.y>=865){
		derecha.transform.position = new Vector3(800,-500,196);
		izquierda.transform.position = new Vector3(350,-500,196);
		changeImage();
	}else{
		derecha.transform.position += new Vector3(0,1,0)*Time.deltaTime*100;
		izquierda.transform.position += new Vector3(0,1,0)*Time.deltaTime*100;
	}
	
}

void changeImage()
{	
	num = UnityEngine.Random.Range(0,imagen.Length-1);
	num2 = UnityEngine.Random.Range(0,imagen.Length-1);
	derecha.transform.localRotation = Quaternion.Euler(0, 180, 0);
	if(num!=num2){
		if(num==imagen.Length-1){
			izquierda.sprite=imagen[num2];
			derecha.sprite=imagen[num];
		}else{
			derecha.sprite=imagen[num];
			izquierda.sprite=imagen[num2];
		}
	}else{
		num=UnityEngine.Random.Range(0,imagen.Length-1);
	}	
	
}
}

