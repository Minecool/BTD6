namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu;

public class RightMenu : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RightMenu <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Initialise>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public static RightMenu instance; //Field offset: 0x0
	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationStateOpen = 1; //Field offset: 0x0
	public ConfirmPurchaseButton confirmPlacementBtn; //Field offset: 0x20
	public CancelPurchaseButton cancelPlacementBtn; //Field offset: 0x28
	public AudioClip clickSound; //Field offset: 0x30
	private readonly string visibleStateLabel; //Field offset: 0x38

	public RightMenu() { }

	public void HidePowersMenu() { }

	[IteratorStateMachine(typeof(<Initialise>d__7))]
	public virtual IEnumerator Initialise() { }

	private void OnDestroy() { }

	public void SetPowersInteractable(bool interactable) { }

	public void ShowPowersMenu() { }

	public void ToggleAbilityMenu() { }

	private void TogglePowersMenu() { }

}

