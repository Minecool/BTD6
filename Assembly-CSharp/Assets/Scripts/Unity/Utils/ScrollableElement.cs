namespace Assets.Scripts.Unity.Utils;

public class ScrollableElement : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	private ScrollRect parentScrollRect; //Field offset: 0x20

	public ScrollableElement() { }

	private ScrollRect FindScrollRect(Transform transform) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

}

