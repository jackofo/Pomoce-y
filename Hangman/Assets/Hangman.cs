using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hangman : MonoBehaviour
{
	public Image[] hangman = new Image[11];
	public Image endScreen;
	public TextAsset file;
	public TextMeshProUGUI loseCounterText;
	public Transform firstLetterBoxPosition;
	public GameObject canvas;
	public GameObject letterBox;
	public GameObject input;
	public float distance;
	List<Word> words;
	Word word;
	private static int lc = 20;
	public static Hangman instance;
	public static List<string> letters = new List<string>();
	public static GameObject[] Array { get; set; }
	static GameObject[] Array2 { get; set; }
	public static int WinCounter { get; set; }
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
			for (int i = 0; i < 11; i++)
			{
				if (lc <= i)
				{
					instance.hangman[i].enabled = true;
				}
				else
				{
					instance.hangman[i].enabled = false;
				}
			}
		}
	}

	private void Start()
	{
		endScreen.GetComponentInChildren<RectTransform>().gameObject.SetActive(false);
		endScreen.enabled = false;
		words = new List<Word>();
		ConfigInput();
		NewWord();
	}

	public static void Next(bool correct)
	{
		Debug.Log("<color=blue>U WON!!!</color>");
		instance.input.SetActive(true);
		instance.word.Correct = correct;
	}

	void ConfigInput()
	{
		string[] text = file.text.Split('\n');
		foreach (var l in text)
		{
			Regex rgx = new Regex("[^a-z]");
			string str = rgx.Replace(l.ToLower(), "");
			words.Add(new Word(str));
		}
	}

	Word GetWord()
	{
		foreach (var w in words)
		{
			if (!w.Atempt)
			{
				w.Atempt = true;
				return w;
			}
		}

		End();

		return new Word("finish");
	}

	private void End()
	{
		int counterr = 0;
		foreach (var w in words)
		{
			if (w.Correct)
				counterr++;
		}

		endScreen.GetComponentInChildren<TextMeshProUGUI>().text = counterr.ToString();
		endScreen.enabled = true;
		endScreen.GetComponentInChildren<RectTransform>().gameObject.SetActive(true);
	}

	public void NewWord()
	{
		if (Array2 != null)
		{
			foreach (var a in Array2)
			{
				Destroy(a);
			}
		}

		word = GetWord();
		instance = this;
		Array = new GameObject[word.Text.Length];
		Array2 = new GameObject[word.Text.Length];
		for (int i = 0; i < word.Text.Length; i++)
		{
			Array2[i] = Instantiate(letterBox, canvas.transform);
			Array2[i].GetComponentInChildren<Text>().text = word.Text[i].ToString();
			Array2[i].transform.parent = firstLetterBoxPosition;
			//Array2[i].transform.position = firstLetterBoxPosition.position + Vector3.right * distance * i;
			Array[i] = Array2[i].GetComponentInChildren<Text>().gameObject;
			Array[i].SetActive(false);
		}

		letters = new List<string>();
		WinCounter = word.Text.Length;
		LoseCounter = 11;
		input.SetActive(false);
	}
}
