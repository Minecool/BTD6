namespace Assets.Scripts.Unity.Gamepad.DuelAction;

public class ActionButtonHoldState
{
	private const float holdDuration = 1; //Field offset: 0x0
	private ActionButton actionButton; //Field offset: 0x10
	private float holdTime; //Field offset: 0x18
	private float holdProgress; //Field offset: 0x1C
	private bool charging; //Field offset: 0x20

	public ActionButtonHoldState(ActionButton actionButton) { }

	public void CancelPress() { }

	public void InitFocus() { }

	private void StartPress() { }

	public void Update(bool canPress) { }

}

