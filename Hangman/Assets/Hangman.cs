using UnityEngine;
using UnityEngine.UI;

public class Hangman : MonoBehaviour
{
    public static Hangman instance;
    public Text loseCounterText;
    private static int lc = 20;
    public static int LoseCounter
    {
        get
        {
            return lc;
        }

        set
        {
            lc = value;
            instance.loseCounterText.text = lc.ToString();
        }

    }

    public string word = "banan";
    public Transform firstLetterBoxPosition;
    public GameObject canvas;
    public GameObject letterBox;
    public GameObject input;
    public float distance;
    public static GameObject[] Array { get; set; }
    public static int WinCounter { get; set; }

    private void Start()
    {
        instance = this;
        Array = new GameObject[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            Array[i] = Instantiate(letterBox, canvas.transform);
            Array[i].GetComponentInChildren<Text>().text = word[i].ToString();
            Array[i].transform.position = firstLetterBoxPosition.position + Vector3.right * distance * i;
            Array[i] = Array[i].GetComponentInChildren<Text>().gameObject;
            Array[i].SetActive(false);
        }

        WinCounter = word.Length;
    }

    public static void Win()
    {
        Debug.Log("<color=blue>U WON!!!</color>");
    }

    public static void Lose()
    {
        Debug.Log("<color=red>U LOSE!!!</color>");
    }
}
