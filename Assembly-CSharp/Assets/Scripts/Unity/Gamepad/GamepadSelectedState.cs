namespace Assets.Scripts.Unity.Gamepad;

public class GamepadSelectedState : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	public Graphic targetGraphic; //Field offset: 0x20
	private bool selected; //Field offset: 0x28
	private SolidShadow solidShadow; //Field offset: 0x30

	private SolidShadow SolidShadow
	{
		private get { } //Length: 339
	}

	public GamepadSelectedState() { }

	[CompilerGenerated]
	private void <Start>b__10_0(InputSystemMode x) { }

	private SolidShadow get_SolidShadow() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void SetSelected(bool _selected) { }

	private void Start() { }

	private override void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData) { }

	private override void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData) { }

}

