namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class GameEditorViewModel
{
	internal sealed class OnAddActor : MulticastDelegate
	{

		public OnAddActor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ActorPrefabModelData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ActorPrefabModelData data) { }

	}

	internal sealed class OnRemoveActor : MulticastDelegate
	{

		public OnRemoveActor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ActorPrefabModelData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ActorPrefabModelData data) { }

	}

	internal sealed class OnSave : MulticastDelegate
	{

		public OnSave(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnShowPrefabsClicked : MulticastDelegate
	{

		public OnShowPrefabsClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameEditorPrefabType type, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameEditorPrefabType type) { }

	}

	[CompilerGenerated]
	private GameEditorPrefabType <SelectedPrefabType>k__BackingField; //Field offset: 0x10

	public GameEditorPrefabAssets GameEditorData
	{
		 get { } //Length: 54
	}

	public GameEditorPrefabType SelectedPrefabType
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GameEditorViewModel() { }

	public GameEditorPrefabAssets get_GameEditorData() { }

	[CompilerGenerated]
	public GameEditorPrefabType get_SelectedPrefabType() { }

	private void OnAddActorTriggered(ActorPrefabModelData data) { }

	public void OnDestroy() { }

	public void OnRemoveActorTriggered(ActorPrefabModelData data) { }

	private void OnSaveAndSerializeGameEditor() { }

	public void OnShowPrefabsClickedTriggered(GameEditorPrefabType prefabType) { }

	[CompilerGenerated]
	public void set_SelectedPrefabType(GameEditorPrefabType value) { }

}

