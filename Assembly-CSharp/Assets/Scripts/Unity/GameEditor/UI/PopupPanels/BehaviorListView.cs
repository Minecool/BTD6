namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorListView : VariableViewComponent
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public BehaviorListView <>4__this; //Field offset: 0x10
		public BehaviorViewModel bVM; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <OnAddingComplete>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	public TextMeshProUGUI behaviourName; //Field offset: 0x38
	public Button addBtn; //Field offset: 0x40
	public Button clearBtn; //Field offset: 0x48
	public Button expandButton; //Field offset: 0x50
	public Transform container; //Field offset: 0x58
	[CompilerGenerated]
	private BehaviorListViewModel <ViewModel>k__BackingField; //Field offset: 0x60

	public private BehaviorListViewModel ViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public BehaviorListView() { }

	[CompilerGenerated]
	private void <Bind>b__9_0() { }

	[CompilerGenerated]
	private void <Bind>b__9_1() { }

	[CompilerGenerated]
	private void <Bind>b__9_2() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	protected virtual void ClearContainer() { }

	[CompilerGenerated]
	public BehaviorListViewModel get_ViewModel() { }

	private void OnAddingComplete(BehaviorViewModel bVM) { }

	private void OnRemoveAllListItemsClicked() { }

	protected virtual void OnUpdateView() { }

	protected virtual void OnValueChanged() { }

	public virtual void Release() { }

	private void RemoveListItemsConfirmed() { }

	[CompilerGenerated]
	private void set_ViewModel(BehaviorListViewModel value) { }

	public void ToggleContainer() { }

}

