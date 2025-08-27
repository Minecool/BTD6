namespace Assets.Scripts.Unity.Gamepad.Jewel;

public class JewelBarButton : BaseJewelBarControl
{
	[SerializeField]
	private Button button; //Field offset: 0x50

	public JewelBarButton() { }

	public virtual Selectable GetSelectable() { }

	protected virtual void OnSubmitSelectable() { }

}

