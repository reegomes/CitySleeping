using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public class VotingSystem : NetworkBehaviour {
public class SistemaDeVotos3 : MonoBehaviour
{
    public GameObject[] players;
    Toggle[] Toggle;

    //[SyncVar]
    Dictionary<string, int> voteCounts = new Dictionary<string, int>();
    bool currentVote;
    string voteString;
    void Start()
    { 
        Toggle = new Toggle[players.Length];
    }
    void Update()
    {
        foreach (GameObject item in players)
        {
            Debug.Log("Dentro do forech: " + item.name.ToString());
        }
    }
    public void OnValueChange()
    {
       for (int i = 0; i < players.Length; i++)
       {
           Toggle[i] = players[i].GetComponent<Toggle>();
           players[i].name.ToString();
           Debug.Log(players[i].ToString());
       }
    }
}
