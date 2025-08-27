namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class StampLayerButton : EditorLayerButton
{
	internal sealed class OnSetAndReorderSortingLayer : MulticastDelegate
	{

		public OnSetAndReorderSortingLayer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int layerIndex, int baseSortingLayer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int layerIndex, int baseSortingLayer) { }

	}


	public StampLayerButton() { }

	public virtual void Awake() { }

	public virtual string GetId() { }

	public virtual LayerType GetLayerType() { }

	public virtual string GetLocalisedTitle() { }

	public virtual void Initialise(int categoryLayerIndex, int worldSortingIndex, object metaData) { }

	public virtual void OnButtonClicked() { }

	public virtual void OnDeleteLayerButtonClicked() { }

	private void OnDestroy() { }

	protected virtual void OnSetSelectedTriggered(EditorLayerButton buttonSelected) { }

	public virtual void OnVisibleToggleClicked(bool isOn) { }

	public virtual void ReorderWorldSortingOrder(int newWorldSortingOrderIndex) { }

}

