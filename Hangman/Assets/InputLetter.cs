using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputLetter : MonoBehaviour
{
	public InputField inputField;
	bool found = false;
	List<string> letters = new List<string>();

	public void TextChanged()
	{
		if(letters.Contains(inputField.text))
		{
			inputField.text = "";
			return;
		}

		letters.Add(inputField.text);
		foreach (var a in Hangman.Array)
		{
			var letter = a.GetComponentInChildren<Text>();
			if (letter.text == inputField.text)
			{
				found = true;
				letter.gameObject.SetActive(true);
				Hangman.WinCounter--;
				if(Hangman.WinCounter == 0)
				{
					Hangman.Win();
				}
			}
		}

		inputField.text = "";
		if(!found)
		{
			Hangman.LoseCounter--;
			if(Hangman.LoseCounter == 0)
			{
				Hangman.Lose();
			}
		}
		else
		{
			found = false;
		}
	}
}
