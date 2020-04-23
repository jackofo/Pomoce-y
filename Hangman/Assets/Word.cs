public class Word
{
	public string Text { get; set; }
	public bool Correct { get; set; }
	public bool Atempt { get; set; }

	public Word(string text)
	{
		this.Text = text;
		this.Atempt = false;
	}
}
