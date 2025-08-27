namespace Assets.Scripts.Unity.UI_New.Popups;

public class ModdingPopup : Popup
{
	[CompilerGenerated]
	private struct <OnEnable>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ModdingPopup <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI mainMessageTxt; //Field offset: 0x128
	[SerializeField]
	private NK_TextMeshProUGUI continueTxt; //Field offset: 0x130
	[SerializeField]
	private Button closeGameBtn; //Field offset: 0x138
	[SerializeField]
	private Button logoutBtn; //Field offset: 0x140
	[SerializeField]
	private Button continueBtn; //Field offset: 0x148
	[SerializeField]
	private GameObject notSignedInMessageGameObj; //Field offset: 0x150
	[SerializeField]
	private GameObject logoutPanel; //Field offset: 0x158
	private bool hasLinkAccount; //Field offset: 0x160
	private readonly TaskCompletionSource<ModdingPopupChoice> playerChoiceTcs; //Field offset: 0x168

	public ModdingPopup() { }

	[CompilerGenerated]
	private void <ShowLogoutPopup>b__14_0() { }

	[CompilerGenerated]
	private void <ShowLogoutPopup>b__14_1() { }

	private void Awake() { }

	private void ButtonsInteractible(bool isInteractible) { }

	private void CloseGame() { }

	private void Continue() { }

	public Task<ModdingPopupChoice> GetPlayerChoice() { }

	[AsyncStateMachine(typeof(<OnEnable>d__10))]
	private void OnEnable() { }

	private void ShowLogoutPopup() { }

}

