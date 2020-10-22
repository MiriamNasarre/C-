using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Btn : MonoBehaviour
{
	public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
		
        GameObject.Find("Button").GetComponentInChildren<Text>().text ="Comenzar";
		//GameObject.Find("Button").GetComponentInChildren<Text>().text.size=60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void JugarNivel(string nombre){
		SceneManager.LoadScene(nombre);
	}
}
