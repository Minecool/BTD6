namespace Assets.Scripts.Unity.Gamepad.Jewel;

public class JewelBarToggle : BaseJewelBarControl
{
	[SerializeField]
	private Toggle toggle; //Field offset: 0x50

	public JewelBarToggle() { }

	public virtual Selectable GetSelectable() { }

	protected virtual void OnSubmitSelectable() { }

}

