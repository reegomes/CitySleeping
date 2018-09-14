using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour
{
    public string[] users;
    IEnumerator Start()
    {
        WWW ctrlAcess = new WWW("http://localhost/ww/ControlAcess.php");
        yield return ctrlAcess;
        string ctrlAcessString = ctrlAcess.text;
        print(ctrlAcessString);
        users = ctrlAcessString.Split(';');
        print(GetDataValue(users[0], "Username: "));
    }
    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"));
        }
        return value;
    }
}
