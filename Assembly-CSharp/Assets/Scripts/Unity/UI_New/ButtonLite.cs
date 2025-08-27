namespace Assets.Scripts.Unity.UI_New;

[RequireComponent(typeof(RectTransform))]
public class ButtonLite : Selectable, IPointerClickHandler, IEventSystemHandler, IButtonProxy
{
	[SerializeField]
	private ButtonClickedEvent m_OnClick; //Field offset: 0x100

	public override ButtonClickedEvent onClick
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ButtonLite() { }

	private override bool Assets.Scripts.Unity.UI_New.IButtonProxy.get_interactable() { }

	private override void Assets.Scripts.Unity.UI_New.IButtonProxy.set_interactable(bool value) { }

	public override ButtonClickedEvent get_onClick() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void set_onClick(ButtonClickedEvent value) { }

}

