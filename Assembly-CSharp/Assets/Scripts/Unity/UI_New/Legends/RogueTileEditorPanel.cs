namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueTileEditorPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <OnTypeChangedAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueTileEditorPanel <>4__this; //Field offset: 0x20
		public int optionIndex; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PropTypeChangedAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueTileEditorPanel <>4__this; //Field offset: 0x20
		public int index; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Slider heightField; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI heightTxt; //Field offset: 0x28
	[SerializeField]
	private TMP_Dropdown typeField; //Field offset: 0x30
	private RogueTile selectedTile; //Field offset: 0x38
	private List<String> tileTypes; //Field offset: 0x40
	private List<String> propTypes; //Field offset: 0x48
	[SerializeField]
	private Button copyBtn; //Field offset: 0x50
	[SerializeField]
	private TMP_InputField idInput; //Field offset: 0x58
	[SerializeField]
	private TMP_Dropdown propTypeDD; //Field offset: 0x60
	[SerializeField]
	private Toggle shuffleTog; //Field offset: 0x68

	public RogueTileEditorPanel() { }

	private void Awake() { }

	public void Bind(RogueTile selectedTile) { }

	private void CopyTile() { }

	public void DecreaseHeight() { }

	public void IncreaseHeight() { }

	private void OnHeightChanged(float height) { }

	private void OnIdTxtChanged(string txt) { }

	private void OnShuffleChanged(bool isOn) { }

	private void OnTypeChanged(int optionIndex) { }

	[AsyncStateMachine(typeof(<OnTypeChangedAsync>d__19))]
	private Task OnTypeChangedAsync(int optionIndex) { }

	private void PropTypeChanged(int index) { }

	[AsyncStateMachine(typeof(<PropTypeChangedAsync>d__12))]
	private Task PropTypeChangedAsync(int index) { }

	private void RefreshPropTypeDD() { }

}

