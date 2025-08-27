//Type is in global namespace

public class TextRoller : NK_TextMeshProUGUI
{
	private int currentIdx; //Field offset: 0x7D8
	private string fullText; //Field offset: 0x7E0
	[CompilerGenerated]
	private bool <textStarted>k__BackingField; //Field offset: 0x7E8

	[HideInInspector]
	public private bool textStarted
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public TextRoller() { }

	[CompilerGenerated]
	public bool get_textStarted() { }

	public void InterruptRollingText() { }

	[CompilerGenerated]
	private void set_textStarted(bool value) { }

	public void SetRollingText(string txt) { }

	private void Update() { }

}

