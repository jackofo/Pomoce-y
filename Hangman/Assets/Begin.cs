using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    public void GetStrings(string data)
    {
        Hangman.instance.Begin(data);
    }
}