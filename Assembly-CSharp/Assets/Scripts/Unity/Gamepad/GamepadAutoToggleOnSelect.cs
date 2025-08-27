namespace Assets.Scripts.Unity.Gamepad;

[RequireComponent(typeof(Toggle))]
public class GamepadAutoToggleOnSelect : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	private Toggle toggle; //Field offset: 0x20

	public GamepadAutoToggleOnSelect() { }

	private void Awake() { }

	public override void OnSelect(BaseEventData eventData) { }

}

