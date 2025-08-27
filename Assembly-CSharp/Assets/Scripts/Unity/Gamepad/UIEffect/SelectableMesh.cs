namespace Assets.Scripts.Unity.Gamepad.UIEffect;

public class SelectableMesh : Selectable, ISubmitHandler, IEventSystemHandler
{
	private enum ButtonState
	{
		Up = 0,
		Over = 1,
		Down = 2,
	}

	public List<Renderer> meshRenders; //Field offset: 0x100
	private Spring scaleSpring; //Field offset: 0x108
	private ButtonState curState; //Field offset: 0x110
	private ButtonState state; //Field offset: 0x114
	private bool pressed; //Field offset: 0x118
	private bool over; //Field offset: 0x119
	private InteractableObject interactableObject; //Field offset: 0x120
	private Vector3 initialScale; //Field offset: 0x128

	public SelectableMesh() { }

	protected virtual void Awake() { }

	public static SelectableMesh FindFirstActiveSelectable() { }

	private void LateUpdate() { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	private void OnStateChanged(ButtonState state) { }

	private void RefreshState() { }

	private override void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData) { }

}

