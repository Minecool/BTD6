namespace Assets.Scripts.Unity.UI_New;

public class HoverableInfoPopup : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	private const float hoverPopupDelay = 0.2; //Field offset: 0x0
	[SerializeField]
	private GameObject displayablePopup; //Field offset: 0x20
	[SerializeField]
	private TMP_Text popupMessage; //Field offset: 0x28
	private bool isHovering; //Field offset: 0x30
	private float hoverTimer; //Field offset: 0x34
	private bool isDisabled; //Field offset: 0x38

	public HoverableInfoPopup() { }

	public void Disable() { }

	public void Enable() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void SetLocKey(string locKey) { }

	public void SetText(string localizedText) { }

	public void Update() { }

}

