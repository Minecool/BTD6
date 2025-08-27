namespace Assets.Scripts.Unity.Gamepad.InputSystem;

public class SpringSelectable : MultiplayerSelectable
{
	private Spring springX; //Field offset: 0xA0
	private Spring springY; //Field offset: 0xA8
	[SerializeField]
	private SpringConfig configX; //Field offset: 0xB0
	[SerializeField]
	private SpringConfig configY; //Field offset: 0xB8
	[SerializeField]
	private Vector2 restScale; //Field offset: 0xC0
	[SerializeField]
	private Vector2 hoverScale; //Field offset: 0xC8
	private Vector2 targetScale; //Field offset: 0xD0
	[SerializeField]
	private Graphic graphic; //Field offset: 0xD8
	private Material origMaterial; //Field offset: 0xE0
	private Material overrideOverMaterial; //Field offset: 0xE8
	private SolidShadow solidShadow; //Field offset: 0xF0
	private float padding; //Field offset: 0xF8
	private float overWeightTimer; //Field offset: 0xFC
	private bool initCalled; //Field offset: 0x100
	[SerializeField]
	private bool applyScale; //Field offset: 0x101

	private Vector2 pressScale
	{
		private get { } //Length: 73
	}

	public SpringSelectable() { }

	public static void Explicit(GameObject sel, GameObject up, GameObject down, GameObject left, GameObject right) { }

	private Vector2 get_pressScale() { }

	private Graphic GetGraphic(Transform target) { }

	private void LateUpdate() { }

	protected virtual void OnOverChanged(bool isOver) { }

	public virtual void OnPress() { }

	public void OverrideMaterials(Material m) { }

	public static SpringSelectable Register(GameObject gameObject, RectTransform rtRaycastTarget = null, bool allowFakeSelectable = true) { }

	public static SpringSelectable RegisterRaycastTargetOverlay(GameObject gameObject) { }

	private void SelectedPulseUpdate() { }

	private void SetCurrentSize(Vector2 size) { }

	public SpringSelectable SetGraphic(string path) { }

	private void SetGraphic(Graphic graphic) { }

	protected void Start() { }

	private Vector2 ValidateSize(Vector2 size) { }

}

