namespace NinjaKiwi.LiNK.Client;

public abstract class PlayerServiceComponent : MonoBehaviour
{
	public readonly MultiLevelLogger logger; //Field offset: 0x20
	[CompilerGenerated]
	private Api <LiNK>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Parameters <ApiParameters>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Environments <Environment>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private PlayerOptions <Options>k__BackingField; //Field offset: 0x48
	[SerializeField]
	protected PlayerServiceConfiguration configuration; //Field offset: 0x50

	public Parameters ApiParameters
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Environments Environment
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Api LiNK
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public PlayerOptions Options
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Version Version
	{
		 get { } //Length: 78
	}

	protected PlayerServiceComponent() { }

	protected override void Awake() { }

	public SkuSettingsHelper CreateSkuSettingsHelper(JsonSerializerSettings jsonSettings = null, bool useFileCache = true) { }

	[CompilerGenerated]
	public Parameters get_ApiParameters() { }

	[CompilerGenerated]
	public Environments get_Environment() { }

	[CompilerGenerated]
	public Api get_LiNK() { }

	[CompilerGenerated]
	public PlayerOptions get_Options() { }

	public Version get_Version() { }

	public static string GetPlayerEditorFilePath(string fileName) { }

	[Conditional("UNITY_EDITOR")]
	public void PopulateSdkInfo(PlayerEditorLiNKSdkInfo sdkInfo) { }

	[CompilerGenerated]
	protected void set_ApiParameters(Parameters value) { }

	[CompilerGenerated]
	protected void set_Environment(Environments value) { }

	[CompilerGenerated]
	protected void set_LiNK(Api value) { }

	[CompilerGenerated]
	protected void set_Options(PlayerOptions value) { }

	[Conditional("UNITY_EDITOR")]
	private void WritePlayerEditorInfo() { }

}

