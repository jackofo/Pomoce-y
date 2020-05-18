using UnityEngine;
using UnityEngine.UI;

public class InputLetter : MonoBehaviour
{
	bool found = false;

	public void TextChanged(string guess)
	{
		if (Hangman.letters.Contains(guess))
		{
			guess = "";
			return;
		}

		Hangman.letters.Add(guess);
		foreach (var a in Hangman.Array)
		{
			var letter = a.GetComponentInChildren<Text>();
			if (letter.text == guess)
			{
				found = true;
				letter.gameObject.SetActive(true);
				Hangman.WinCounter--;
				if (Hangman.WinCounter == 0)
				{
					Hangman.Next(true);
				}
			}
		}

		guess = "";
		if (!found)
		{
			Hangman.LoseCounter--;
			if (Hangman.LoseCounter == 0)
			{
				Hangman.Next(false);
			}
		}
		else
		{
			found = false;
		}
	}

	public void A()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("a");
	}
	public void A_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ą");
	}
	public void B()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("b");
	}
	public void C()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("c");
	}
	public void C_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ć");
	}
	public void D()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("d");
	}
	public void E()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("e");
	}
	public void E_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ę");
	}
	public void F()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("f");
	}
	public void G()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("g");
	}
	public void H()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("h");
	}
	public void I()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("i");
	}
	public void J()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("j");
	}
	public void K()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("k");
	}
	public void L()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("l");
	}
	public void L_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ł");
	}
	public void M()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("m");
	}
	public void N()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("n");
	}
	public void N_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ń");
	}
	public void O()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("o");
	}
	public void O_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ó");
	}
	public void P()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("p");
	}
	public void Q()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("q");
	}
	public void R()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("r");
	}
	public void S()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("s");
	}
	public void S_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ś");
	}
	public void T()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("t");
	}
	public void U()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("u");
	}
	public void V()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("v");
	}
	public void W()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("w");
	}
	public void X()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("x");
	}
	public void Y()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("y");
	}
	public void Z()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("z");
	}
	public void Z_1()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ź");
	}
	public void Z_2()
	{
		if (Hangman.LoseCounter > 0)
			TextChanged("ż");
	}
}
