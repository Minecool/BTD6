namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public abstract class LibraryItemViewModel : ViewModel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public LibraryItemViewModel <>4__this; //Field offset: 0x10
		public Action confirmedDeleteCallback; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <OnDeleteClicked>b__0() { }

	}

	[CompilerGenerated]
	private CustomPrefabModelData <PrefabModelData>k__BackingField; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 27
	}

	public CustomPrefabModelData PrefabModelData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public LibraryItemViewModel(CustomPrefabModelData data) { }

	public string get_Name() { }

	[CompilerGenerated]
	public CustomPrefabModelData get_PrefabModelData() { }

	protected override void OnConfirmDeleteClicked(Action confirmedDeleteCallback) { }

	public override void OnDeleteClicked(Action confirmedDeleteCallback) { }

	public virtual void OnDestroy() { }

	public override void OnEditClicked() { }

	[CompilerGenerated]
	protected void set_PrefabModelData(CustomPrefabModelData value) { }

}

