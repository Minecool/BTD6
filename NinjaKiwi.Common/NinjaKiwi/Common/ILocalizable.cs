namespace NinjaKiwi.Common;

public interface ILocalizable
{

	public bool AlignmentSwapped
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool AutoLocalize
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string LocalizeKey
	{
		 get { } //Length: 0
	}

	public string text
	{
		 set { } //Length: 0
	}

	public bool get_AlignmentSwapped() { }

	public bool get_AutoLocalize() { }

	public string get_LocalizeKey() { }

	public void set_AlignmentSwapped(bool value) { }

	public void set_AutoLocalize(bool value) { }

	public void set_text(string value) { }

	public void SetupFontFeatures() { }

}

