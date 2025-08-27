namespace Assets.Scripts.Unity.UI_New.Utils;

[RequireComponent(typeof(RectTransform))]
public class SafeArea : MonoBehaviour
{
	[SerializeField]
	private bool ignoreX; //Field offset: 0x20
	[SerializeField]
	private bool ignoreY; //Field offset: 0x21
	[SerializeField]
	private bool symmetricalX; //Field offset: 0x22
	[SerializeField]
	private bool symmetricalY; //Field offset: 0x23
	private float canvasScaleFactor; //Field offset: 0x24
	private RectTransform rectTransform; //Field offset: 0x28
	private float jewelBarOffset; //Field offset: 0x30
	private DeviceOrientation orientation; //Field offset: 0x34

	public SafeArea() { }

	private void ApplySafeArea(bool force = false) { }

	private void OnDestroy() { }

	private void Start() { }

	private void Update() { }

	private void UpdateJewelBarActive(bool active) { }

}

