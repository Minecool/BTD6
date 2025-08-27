namespace Assets.Scripts.Unity.UI_New;

[RequireComponent(typeof(RectTransform), typeof(Image))]
public class Lightbox : Selectable, IPointerClickHandler, IEventSystemHandler, IButtonProxy
{
	[SerializeField]
	private ButtonClickedEvent m_OnClick; //Field offset: 0x100
	[SerializeField]
	private Sprite visionOSSpriteOverride; //Field offset: 0x108
	[SerializeField]
	private Material visionOSMaterialOverride; //Field offset: 0x110
	private RectTransform _canvasRect; //Field offset: 0x118
	private RectTransform _rectTransform; //Field offset: 0x120

	public override ButtonClickedEvent onClick
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Lightbox() { }

	private override bool Assets.Scripts.Unity.UI_New.IButtonProxy.get_interactable() { }

	private override void Assets.Scripts.Unity.UI_New.IButtonProxy.set_interactable(bool value) { }

	protected virtual void Awake() { }

	public override ButtonClickedEvent get_onClick() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void set_onClick(ButtonClickedEvent value) { }

	private void Update() { }

}

