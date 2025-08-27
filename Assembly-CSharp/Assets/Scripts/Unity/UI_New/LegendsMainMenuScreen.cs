namespace Assets.Scripts.Unity.UI_New;

public class LegendsMainMenuScreen : GameMenu
{
	[CompilerGenerated]
	private struct <Load3DWorld>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LegendsMainMenuScreen <>4__this; //Field offset: 0x20
		public LegendsType legendsType; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LegendsMainMenuScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private LegendsMainMenuData <legendsData>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReOpen>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LegendsMainMenuScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private LegendsMainMenuData <legendsData>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class BackClickedLegends : MulticastDelegate
	{

		public BackClickedLegends(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class LegendsCloseAnim : MulticastDelegate
	{

		public LegendsCloseAnim(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class LegendsReopenAnim : MulticastDelegate
	{

		public LegendsReopenAnim(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[SerializeField]
	private Transform worldContainer; //Field offset: 0x48
	[SerializeField]
	private Button homeBtn; //Field offset: 0x50
	[SerializeField]
	private Button playerProfileBtn; //Field offset: 0x58
	[SerializeField]
	private Button settingsBtn; //Field offset: 0x60
	[SerializeField]
	private Button featsBtn; //Field offset: 0x68
	[SerializeField]
	private Button storeBtn; //Field offset: 0x70
	[SerializeField]
	private Button trophyStoreBtn; //Field offset: 0x78
	[SerializeField]
	private Button eventsBtn; //Field offset: 0x80
	private PlayerInfo playerInfo; //Field offset: 0x88
	private GameObject worldObj; //Field offset: 0x90
	[CompilerGenerated]
	private LegendsMainMenuData <MenuData>k__BackingField; //Field offset: 0x98

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LegendsType LegendsType
	{
		private get { } //Length: 29
	}

	private LegendsMainMenuData MenuData
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public LegendsMainMenuScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	protected virtual void Awake() { }

	private void CloseAnim() { }

	private void FeatsClicked() { }

	private LegendsDataModel get_LegendsData() { }

	private LegendsType get_LegendsType() { }

	[CompilerGenerated]
	private LegendsMainMenuData get_MenuData() { }

	private string GetLegendsMainMenuName(LegendsType legendsType) { }

	private void HomeClicked() { }

	private void IapStoreClicked() { }

	[AsyncStateMachine(typeof(<Load3DWorld>d__25))]
	private Task Load3DWorld(LegendsType legendsType) { }

	[AsyncStateMachine(typeof(<Open>d__22))]
	public virtual void Open(object data) { }

	private void OpenAnim() { }

	public virtual bool OverrideClose() { }

	private void RefreshUIs() { }

	[AsyncStateMachine(typeof(<ReOpen>d__23))]
	public virtual void ReOpen(object data) { }

	[CompilerGenerated]
	private void set_MenuData(LegendsMainMenuData value) { }

	private void SettingsClicked() { }

	private void ShowInfoPopup() { }

	private void ShowPlayerProfile() { }

	private void TrophyStoreClicked() { }

}

