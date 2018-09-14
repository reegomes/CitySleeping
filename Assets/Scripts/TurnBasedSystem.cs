using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TurnBasedSystem : MonoBehaviour {
	public GameObject SendVotes, Voted, Chat;
	public TextMeshProUGUI Tretatext;
	float timer; int timerInt; public Text textTimer;

	void Start () {
		StartCoroutine(StartRounds());
		timer = 40;
	}
	private void Update() {
		Tretatext.text = "Está rolando um chat nesse momento, você tem que usar seus argumentos agora.";
		textTimer.text = "Tempo: " + timerInt.ToString();
		timer -= Time.deltaTime;
		timerInt = (int)timer;
	}
	public IEnumerator StartRounds(){
		yield return new WaitForSeconds(40);
		SendVotes.SetActive(true);
		StartCoroutine(AwaitingVotes());
		timer = 15;
	}
	public IEnumerator AwaitingVotes(){
		yield return new WaitForSeconds(15);
		Chat.SetActive(false);
		StartCoroutine(CalculatingVotes());
		timer = 10;
	}
	public IEnumerator CalculatingVotes(){
		yield return new WaitForSeconds(10);
		SendVotes.SetActive(false);
		Voted.SetActive(false);
		Chat.SetActive(true);
		StartCoroutine(StartRounds());
		timer = 40;
	}
}
