namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class AbilityButton : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AbilityButton <>4__this; //Field offset: 0x20

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
		public <Initialise>d__21(int <>1__state) { }

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

	public NK_TextMeshProUGUI infoTitle; //Field offset: 0x20
	public NK_TextMeshProUGUI infoDescription; //Field offset: 0x28
	public GameObject infoPanel; //Field offset: 0x30
	public Button button; //Field offset: 0x38
	public Image cooldownFade; //Field offset: 0x40
	public Image icon; //Field offset: 0x48
	public Image disabledImage; //Field offset: 0x50
	public GameObject activeEffect; //Field offset: 0x58
	public GameObject highLightedEffect; //Field offset: 0x60
	public GameObject maxGraveyardPip; //Field offset: 0x68
	public NK_TextMeshProUGUI count; //Field offset: 0x70
	protected AbilityToSimulation ability; //Field offset: 0x78
	[CompilerGenerated]
	private SpriteReference <currentAbilityIcon>k__BackingField; //Field offset: 0x80
	private bool isHighlighted; //Field offset: 0x88

	public Button Button
	{
		 get { } //Length: 5
	}

	public private SpriteReference currentAbilityIcon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public AbilityButton() { }

	protected void CheckAndActivateAbility(AbilityToSimulation alty) { }

	public override void CheckCooldown() { }

	private void CheckEnabled() { }

	public Button get_Button() { }

	[CompilerGenerated]
	public SpriteReference get_currentAbilityIcon() { }

	public override AbilityToSimulation GetAbility() { }

	[IteratorStateMachine(typeof(<Initialise>d__21))]
	public virtual IEnumerator Initialise() { }

	public override void OnClick() { }

	public void OnRoundEnd() { }

	public override void OnTriggerHighlight(bool isHighlighted) { }

	public virtual void OnUpdate() { }

	[CompilerGenerated]
	private void set_currentAbilityIcon(SpriteReference value) { }

	public override void SetAbility(AbilityToSimulation value, int ownerId) { }

	private void SetActive(GameObject obj, bool active) { }

	private void SetActive(bool active) { }

	protected override void UpdateButton() { }

	private void UpdateCount() { }

}

