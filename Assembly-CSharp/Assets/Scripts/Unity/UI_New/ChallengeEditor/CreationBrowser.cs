namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class CreationBrowser : GameMenu
{
	[CompilerGenerated]
	private struct <CreatePanel>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CreationBrowser <>4__this; //Field offset: 0x20
		public string creationId; //Field offset: 0x28
		private GameObject <obj>5__2; //Field offset: 0x30
		private TaskAwaiter<CreatorModelWrapper`1<MapEditorCreatorModel>> <>u__1; //Field offset: 0x38
		private TaskAwaiter<CreatorModelWrapper`1<GameEditorCreatorModel>> <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class MenuOpenInfo
	{
		[CompilerGenerated]
		private readonly ContentType <ContentType>k__BackingField; //Field offset: 0x10

		public ContentType ContentType
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public MenuOpenInfo(ContentType contentType) { }

		[CompilerGenerated]
		public ContentType get_ContentType() { }

	}

	[SerializeField]
	private GameObject mapPanelTemplate; //Field offset: 0x48
	[SerializeField]
	private GameObject gamePanelTemplate; //Field offset: 0x50
	[SerializeField]
	private GameObject addPanelTemplate; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x60
	[SerializeField]
	private Transform contentParent; //Field offset: 0x68
	private ContentType contentType; //Field offset: 0x70
	private GameObject addPanel; //Field offset: 0x78

	public CreationBrowser() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<CreatePanel>d__11))]
	private Task CreatePanel(string creationId) { }

	private GameObject GetPanelTemplate() { }

	private void OnCreateButtonClicked() { }

	public virtual void Open(object data) { }

}

