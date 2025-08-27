namespace Assets.Scripts.Unity.Utils;

public class ScrollableSlider : Slider, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[SerializeField]
	private float timesMoreVerticalTooScroll; //Field offset: 0x168
	private ScrollRect parentScrollRect; //Field offset: 0x170
	private bool draggingScrollRect; //Field offset: 0x178

	public ScrollableSlider() { }

	protected virtual void Awake() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

}

