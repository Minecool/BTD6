namespace Assets.Scripts.Unity.Utils;

public class CustomDcSliderWithDeadzone : Slider, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public Button button0; //Field offset: 0x168
	public Button button1; //Field offset: 0x170
	public Button button2; //Field offset: 0x178
	public Button button3; //Field offset: 0x180
	public Button button4; //Field offset: 0x188
	public DCRestrictionUpgradeDisplay restrictionUpgradeDisplay; //Field offset: 0x190
	private Vector2 deltaAtBegindDrag; //Field offset: 0x198
	private bool draggingSlider; //Field offset: 0x1A0
	private bool draggingSliderDeltaMinMet; //Field offset: 0x1A1

	public CustomDcSliderWithDeadzone() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	private void UpdateDisplay(bool disable) { }

}

