using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SistemaDeVotos2 : MonoBehaviour
{
    Toggle toggle;
    public List<GameObject> players;
    //[SyncVar]
    Dictionary<string, int> voteCounts = new Dictionary<string, int>();
    bool currentVote;
    string voteString;
    void Start()
    { 
        toggle = GetComponent<Toggle>();
        foreach (var item in players)
        {
            voteString = toggle.GetComponentInChildren<Text>().text;
            voteCounts.Add(voteString,0);
            Debug.Log("Adicionados no dicionario: " + voteCounts.Values);
        }
    }
    void Update()
    {
        //Peguei o valor
        //Debug.Log("Valor: " + nToggle[2].GetComponentInChildren<Text>().text);
        if (toggle.isOn)
        {
            Debug.Log("Valor no toggle is on: " + toggle.GetComponentInChildren<Text>().text);
            //OnValueChange();
        }
        if(currentVote = true && toggle.isOn){
            voteCounts[voteString] += 1;
            print("Votados já na lista: " + voteCounts);
        }
        int size = voteCounts.Count;
        print(size);
    }
    public void OnValueChange()
    {
        //voteCounts[toggle.GetComponentInChildren<Text>().text] += 1;
        //voteCounts.Add(toggle.GetComponentInChildren<Text>().text, 1);
        currentVote = true;
    }
}
