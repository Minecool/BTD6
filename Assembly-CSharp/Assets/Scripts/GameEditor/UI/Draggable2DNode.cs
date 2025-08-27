namespace Assets.Scripts.GameEditor.UI;

public abstract class Draggable2DNode : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	private RectTransform rectTransform; //Field offset: 0x20
	private Canvas canvas; //Field offset: 0x28
	private bool isDragging; //Field offset: 0x30
	public GameObject highlightedGlowObj; //Field offset: 0x38

	protected Draggable2DNode() { }

	private void Awake() { }

	public override void OnDrag(PointerEventData eventData) { }

	protected override void OnDraggingEndEvent() { }

	protected override void OnDraggingStartEvent() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

}

