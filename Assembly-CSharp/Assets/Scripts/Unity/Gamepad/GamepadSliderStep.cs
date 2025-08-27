namespace Assets.Scripts.Unity.Gamepad;

[RequireComponent(typeof(Slider))]
public class GamepadSliderStep : MonoBehaviour, IMoveHandler, IEventSystemHandler, IEndDragHandler, ISelectHandler, IDeselectHandler, ISubmitHandler, ICancelHandler
{
	private const float firstTickDuration = 0.3; //Field offset: 0x0
	private const float tickDuration = 0.05; //Field offset: 0x0
	[SerializeField]
	private float step; //Field offset: 0x20
	private Slider slider; //Field offset: 0x28
	private float previousSliderValue; //Field offset: 0x30
	private float stepCountdownDec; //Field offset: 0x34
	private float stepCountdownInc; //Field offset: 0x38
	private bool hasFocus; //Field offset: 0x3C
	private Image handle; //Field offset: 0x40

	public GamepadSliderStep() { }

	private void Awake() { }

	public void Dec() { }

	private void GamepadKey_LeftShoulder_canceled(CallbackContext obj) { }

	private void GamepadKey_LeftShoulder_started(CallbackContext obj) { }

	private void GamepadKey_RightShoulder_canceled(CallbackContext obj) { }

	private void GamepadKey_RightShoulder_started(CallbackContext obj) { }

	public void Inc() { }

	public override void OnCancel(BaseEventData eventData) { }

	public override void OnDeselect(BaseEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnMove(AxisEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	private void OnSliderValueChanged(float value) { }

	public override void OnSubmit(BaseEventData eventData) { }

	private void SetFocus(bool hasFocus) { }

	private void SetValue(float value) { }

	private void Update() { }

}

