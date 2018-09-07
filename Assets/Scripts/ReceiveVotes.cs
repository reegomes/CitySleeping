using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ReceiveVotes : MonoBehaviour
{
    private Dictionary<string, int> voteCounts = new Dictionary<string, int>(){
        {"Jogador 1", 0},
        {"Jogador 2", 0},
        {"Jogador 3", 0},
        {"Jogador 4", 0},
        {"Jogador 5", 0},
        {"Jogador 6", 0},
        {"Jogador 7", 0},
        {"Jogador 8", 0},
        {"Jogador 9", 0},
        {"Jogador 10", 0}        
    };
    internal void SetVoteCounts(string v1, int v2)
    {
        switch (v1)
        {
            case "Jogador 1":
            voteCounts["Jogador 1"]+=1;
            break;
            case "Jogador 2":
            voteCounts["Jogador 2"]+=1;
            break;
            case "Jogador 3":
            voteCounts["Jogador 3"]+=1;
            break;
            case "Jogador 4":
            voteCounts["Jogador 4"]+=1;
            break;
            case "Jogador 5":
            voteCounts["Jogador 5"]+=1;
            break;
            case "Jogador 6":
            voteCounts["Jogador 6"]+=1;
            break;
            case "Jogador 7":
            voteCounts["Jogador 7"]+=1;
            break;
            case "Jogador 8":
            voteCounts["Jogador 8"]+=1;
            break;
            case "Jogador 9":
            voteCounts["Jogador 9"]+=1;
            break;
            case "Jogador 10":
            voteCounts["Jogador 10"]+=1;
            break;
            default:
            break;
        }
        foreach (KeyValuePair<string, int>item in voteCounts)
        {
            Debug.Log("Jogador "+ item.Key + "Votos " + item.Value);
        }

        foreach (KeyValuePair<string, int> item in voteCounts.OrderBy(item => voteCounts[item.Key]))
        { 
            Debug.Log(item.Value);
        }

    }
    public void GetHigherValue(){
        
    }
}