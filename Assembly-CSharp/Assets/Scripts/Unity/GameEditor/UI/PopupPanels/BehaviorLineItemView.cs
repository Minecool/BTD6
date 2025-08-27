namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorLineItemView : VariableViewComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__8_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Bind>b__8_2() { }

	}

	public TextMeshProUGUI behaviourName; //Field offset: 0x38
	public Button editBtn; //Field offset: 0x40
	public Button deleteBtn; //Field offset: 0x48
	public Button expandButton; //Field offset: 0x50
	[CompilerGenerated]
	private BehaviorViewModel <BehaviorVM>k__BackingField; //Field offset: 0x58

	public private BehaviorViewModel BehaviorVM
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public BehaviorLineItemView() { }

	[CompilerGenerated]
	private void <Bind>b__8_0() { }

	[CompilerGenerated]
	private void <Bind>b__8_1() { }

	[CompilerGenerated]
	private void <Bind>b__8_3() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	[CompilerGenerated]
	public BehaviorViewModel get_BehaviorVM() { }

	protected virtual void OnUpdateView() { }

	protected virtual void OnValueChanged() { }

	public virtual void Release() { }

	[CompilerGenerated]
	private void set_BehaviorVM(BehaviorViewModel value) { }

}

