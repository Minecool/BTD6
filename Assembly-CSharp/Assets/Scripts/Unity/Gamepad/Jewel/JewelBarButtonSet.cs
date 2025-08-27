namespace Assets.Scripts.Unity.Gamepad.Jewel;

public class JewelBarButtonSet : BaseJewelBarControl
{
	private Button button; //Field offset: 0x50
	[SerializeField]
	private Button[] buttons; //Field offset: 0x58
	[SerializeField]
	private TMP_Text[] textSet; //Field offset: 0x60

	public JewelBarButtonSet() { }

	public virtual Selectable GetSelectable() { }

	protected virtual void OnSubmitSelectable() { }

	protected virtual void Start() { }

	protected virtual void Tick() { }

	private void UpdateButtonStates() { }

}

