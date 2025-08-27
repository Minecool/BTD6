namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class GameEditorLibraryViewModel : ViewModel
{
	internal sealed class OnEditItemClicked : MulticastDelegate
	{

		public OnEditItemClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomPrefabModelData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomPrefabModelData data) { }

	}

	internal sealed class OnItemsListChanged : MulticastDelegate
	{

		public OnItemsListChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	private GameEditorPrefabType <PrefabType>k__BackingField; //Field offset: 0x10

	public private GameEditorPrefabType PrefabType
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public GameEditorLibraryViewModel(GameEditorPrefabType prefabType) { }

	[CompilerGenerated]
	public GameEditorPrefabType get_PrefabType() { }

	private List<CustomPrefabModelData> GetActors() { }

	private List<CustomPrefabModelData> GetEventSystems() { }

	public List<CustomPrefabModelData> GetItems(GameEditorPrefabType prefabType) { }

	public void Initialise() { }

	public void OnCreateClickedTriggered() { }

	public virtual void OnDestroy() { }

	public void OnEditItemClickedTriggered(CustomPrefabModelData data) { }

	[CompilerGenerated]
	private void set_PrefabType(GameEditorPrefabType value) { }

}

