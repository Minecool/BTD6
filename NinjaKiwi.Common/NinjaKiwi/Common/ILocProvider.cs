namespace NinjaKiwi.Common;

public interface ILocProvider
{

	public Language ActiveLanguage
	{
		 get { } //Length: 0
	}

	public bool ContainsKey(string key) { }

	public bool ContainsKeyEnglish(string key) { }

	public string Format(string key, Object[] args) { }

	public string FormatEnglish(string key, Object[] args) { }

	public Language get_ActiveLanguage() { }

	public string GetText(string key) { }

	public string GetTextEnglish(string key) { }

}

