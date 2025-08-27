namespace Assets.Scripts.Unity.UI_New.PlayerStats;

public class OnMouseOverMessage : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler, IDeselectHandler
{
	[CompilerGenerated]
	private sealed class <DoInSeconds>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float seconds; //Field offset: 0x20
		public Action action; //Field offset: 0x28

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
		public <DoInSeconds>d__14(int <>1__state) { }

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

	public GameObject infoPopUpPrefab; //Field offset: 0x20
	public string titleLoc; //Field offset: 0x28
	public string descriptionLoc; //Field offset: 0x30
	public string modeLoc; //Field offset: 0x38
	public int xModifier; //Field offset: 0x40
	public int yModifier; //Field offset: 0x44
	private GameObject infoPopUp; //Field offset: 0x48
	private bool canShow; //Field offset: 0x50
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; //Field offset: 0x51

	public bool Interactable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public OnMouseOverMessage() { }

	[CompilerGenerated]
	private void <Awake>b__12_0(InputSystemMode mode) { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<DoInSeconds>d__14))]
	private static IEnumerator DoInSeconds(float seconds, Action action) { }

	[CompilerGenerated]
	public bool get_Interactable() { }

	private string GetText(String[] locKeys) { }

	public override void OnDeselect(BaseEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData data) { }

	public override void OnPointerExit(PointerEventData data) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	private string ReadLocs(string locKey) { }

	[CompilerGenerated]
	public void set_Interactable(bool value) { }

	private void TryShowInfoPopup() { }

}

