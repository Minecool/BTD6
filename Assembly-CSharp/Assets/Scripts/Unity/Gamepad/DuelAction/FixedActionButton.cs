namespace Assets.Scripts.Unity.Gamepad.DuelAction;

public class FixedActionButton : ActionButton
{
	public Image fixedIcon; //Field offset: 0x90
	public TMP_Text captionText; //Field offset: 0x98

	public FixedActionButton() { }

	private void Awake() { }

	protected virtual void SetVis(bool show) { }

	protected virtual void Start() { }

}

