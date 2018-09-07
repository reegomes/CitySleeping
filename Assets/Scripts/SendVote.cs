using UnityEngine;
using UnityEngine.UI;
public class SendVote : ReceiveVotes {
	public Toggle toggle;
    static bool isOk;
	void Start () {
		toggle = GetComponent<Toggle>();
	}
	void Update () {
		if(toggle.isOn && isOk == true){
			OnValueChange();
            isOk = false;
		}
	}
	public void OnValueChange(){
        SetVoteCounts(toggle.GetComponentInChildren<Text>().text, 1);
	}
    public void IsOkThen(){
        isOk = true;
    }
}