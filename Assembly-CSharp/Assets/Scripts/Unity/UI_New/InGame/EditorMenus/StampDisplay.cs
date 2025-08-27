namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

[RequireComponent(typeof(SpriteRenderer))]
public class StampDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LoadData>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StampDisplay <>4__this; //Field offset: 0x20
		public MapEditorStampData stampData; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public SpriteRenderer spriteRenderer; //Field offset: 0x20
	[CompilerGenerated]
	private MapEditorStampData <StampData>k__BackingField; //Field offset: 0x28

	public MapEditorStampData StampData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public StampDisplay() { }

	private void Awake() { }

	[CompilerGenerated]
	public MapEditorStampData get_StampData() { }

	[AsyncStateMachine(typeof(<LoadData>d__6))]
	public Task LoadData(MapEditorStampData stampData) { }

	[CompilerGenerated]
	public void set_StampData(MapEditorStampData value) { }

}

