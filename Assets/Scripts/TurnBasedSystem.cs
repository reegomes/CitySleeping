using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TurnBasedSystem : MonoBehaviour {
	public GameObject SendVotes, Voted, Chat;
	public TextMeshProUGUI Tretatext;
	void Start () {
		StartCoroutine(StartRounds());
	}
	private void Update() {
		Tretatext.text = "Está rolando um chat nesse momento, você tem que usar seus argumentos agora.";
	}
	public IEnumerator StartRounds(){
		yield return new WaitForSeconds(40);
		SendVotes.SetActive(true);
		StartCoroutine(AwaitingVotes());
	}
	public IEnumerator AwaitingVotes(){
		yield return new WaitForSeconds(15);
		Chat.SetActive(false);
		StartCoroutine(CalculatingVotes());
	}
	public IEnumerator CalculatingVotes(){
		yield return new WaitForSeconds(10);
		SendVotes.SetActive(false);
		Voted.SetActive(false);
		Chat.SetActive(true);
		StartCoroutine(StartRounds());
	}
}
