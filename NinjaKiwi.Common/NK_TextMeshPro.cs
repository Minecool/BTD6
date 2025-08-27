//Type is in global namespace

public class NK_TextMeshPro : TextMeshPro, ILocalizable
{
	[LocalizedText]
	[SerializeField]
	private string localizeKey; //Field offset: 0x790
	[SerializeField]
	private bool noRTLAutoAlign; //Field offset: 0x798
	[CompilerGenerated]
	private bool <AutoLocalize>k__BackingField; //Field offset: 0x799
	[CompilerGenerated]
	private bool <AlignmentSwapped>k__BackingField; //Field offset: 0x79A

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

	public NK_TextMeshPro() { }

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

