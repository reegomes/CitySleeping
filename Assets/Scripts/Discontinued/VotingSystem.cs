using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Networking;

//public class VotingSystem : NetworkBehaviour {
public class VotingSystem : MonoBehaviour {
	//public Toggle[] nToggle;
	public Toggle toggle;
	public static string nameOfToggle;
	// Use this for initialization
	void Start () {
		toggle = GetComponent<Toggle>();
	}
	
	// Update is called once per frame
	void Update () {
		//Peguei o valor
		//Debug.Log("Valor: " + nToggle[2].GetComponentInChildren<Text>().text);
		if(toggle.isOn){
			OnValueChange();
			nameOfToggle = toggle.GetComponentInChildren<Text>().text;
		}
	}
	public void OnValueChange(){
		Debug.Log("Valor: " + toggle.GetComponentInChildren<Text>().text);
	}
}
