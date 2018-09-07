using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class VoteButton : MonoBehaviour
{
    public GameObject[] voteGroupToggle;
    public Submit[] playersToVote;
    private void Start()
    {
        playersToVote = new Submit[voteGroupToggle.Length];
    }
    public void OnClickInVote()
    {
        for (int i = 0; i < playersToVote.Length; i++)
        {
            playersToVote[i] = SaveVote(voteGroupToggle[i]);
        }
    }
    public Submit SaveVote(GameObject GroupToggle)
    {
        Submit result = new Submit();
        GameObject q = GroupToggle.transform.Find("VoteText").gameObject;
        bool answer = GameObject.Find("Toggle").GetComponent<Toggle>().isOn = true;
        result.answer = answer;
        result.question = q.GetComponent<TMPro.TextMeshProUGUI>().text;
        return result;
    }
    private void Update() {
        //Apagar depois de testar
        Debug.Log("Valor: ");
    }
}


[System.Serializable]
public class Submit
{
    public string question;
    public bool answer;
}