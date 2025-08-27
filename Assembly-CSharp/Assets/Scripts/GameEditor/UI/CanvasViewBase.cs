namespace Assets.Scripts.GameEditor.UI;

public class CanvasViewBase : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	internal sealed class HomeBtnClicked : MulticastDelegate
	{

		public HomeBtnClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnCreateGraphNodeEvent : MulticastDelegate
	{

		public OnCreateGraphNodeEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GraphNodeModelDescriptorDef prefab, Model metadata, GraphPort graphPort, AsyncCallback callback, object object) { }

		public override GraphNode EndInvoke(IAsyncResult result) { }

		public override GraphNode Invoke(GraphNodeModelDescriptorDef prefab, Model metadata = null, GraphPort graphPort = null) { }

	}

	internal sealed class OnRemoveNodeClicked : MulticastDelegate
	{

		public OnRemoveNodeClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GraphNode nodeToRemove, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GraphNode nodeToRemove) { }

	}

	protected string canvasName; //Field offset: 0x20
	protected GraphNode baseGraphNode; //Field offset: 0x28
	protected List<GraphNode> canvasNodes; //Field offset: 0x30
	public RectTransform canvasRect; //Field offset: 0x38
	public Canvas canvas; //Field offset: 0x40
	public Button homeBtn; //Field offset: 0x48
	public Button saveBtn; //Field offset: 0x50
	public Button loadBtn; //Field offset: 0x58
	public Button cancelBtn; //Field offset: 0x60
	public Transform rootNodeSpawnerTransform; //Field offset: 0x68
	public bool isPanning; //Field offset: 0x70
	public Vector2 panStartPos; //Field offset: 0x74
	public Vector2 canvasPannerOrigionalPos; //Field offset: 0x7C
	public List<GameEditorRootNodeButton> rootNodeSpawnerButtons; //Field offset: 0x88
	public Vector3 defaultNodeOffset; //Field offset: 0x90
	private bool showingUnassignedProperties; //Field offset: 0x9C

	public CanvasViewBase() { }

	private void Awake() { }

	private void CreateButton(GraphNodeModelDescriptorDef descriptor) { }

	private void HandleTouchPinch() { }

	public override void Initialise(object saveData) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	protected void OnCancelBtnClicked() { }

	public void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	public void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	protected void OnHomeBtnClicked() { }

	protected void OnLoadBtnClicked() { }

	protected void OnSaveBtnClicked() { }

	public override void OnScroll(PointerEventData eventData) { }

	public void RemoveNode(GraphNode nodeToRemove) { }

	private void Update() { }

}

