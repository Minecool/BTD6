//Type is in global namespace

public class NK_TextMeshProUGUI : TextMeshProUGUI, ILocalizable
{
	[LocalizedText]
	[SerializeField]
	private string localizeKey; //Field offset: 0x7C8
	[SerializeField]
	private bool noRTLAutoAlign; //Field offset: 0x7D0
	[CompilerGenerated]
	private bool <AutoLocalize>k__BackingField; //Field offset: 0x7D1
	[CompilerGenerated]
	private bool <AlignmentSwapped>k__BackingField; //Field offset: 0x7D2

	public override bool AlignmentSwapped
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool AutoLocalize
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override string LocalizeKey
	{
		 get { } //Length: 8
	}

	public virtual string text
	{
		 get { } //Length: 7
		 set { } //Length: 8
	}

	public NK_TextMeshProUGUI() { }

	protected virtual void Awake() { }

	[CompilerGenerated]
	public override bool get_AlignmentSwapped() { }

	[CompilerGenerated]
	public override bool get_AutoLocalize() { }

	public override string get_LocalizeKey() { }

	public virtual string get_text() { }

	[CompilerGenerated]
	public override void set_AlignmentSwapped(bool value) { }

	[CompilerGenerated]
	public override void set_AutoLocalize(bool value) { }

	public virtual void set_text(string value) { }

	public void SetText(string sourceText) { }

	public override void SetupFontFeatures() { }

	protected virtual void Start() { }

	private void UpdateText(string text) { }

}

