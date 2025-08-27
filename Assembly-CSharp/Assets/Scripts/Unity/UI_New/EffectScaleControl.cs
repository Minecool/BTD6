namespace Assets.Scripts.Unity.UI_New;

public class EffectScaleControl : MonoBehaviour
{
	internal sealed class OnFXScaleFinalised : MulticastDelegate
	{

		public OnFXScaleFinalised(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(float scale, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(float scale) { }

	}

	private const float kMultiplier = 100; //Field offset: 0x0
	[SerializeField]
	private Slider effectScaleSlider; //Field offset: 0x20
	[SerializeField]
	private TMP_Text effectScaleSliderTxt; //Field offset: 0x28
	[SerializeField]
	private Image icon; //Field offset: 0x30
	[SerializeField]
	private SpriteReference on; //Field offset: 0x38
	[SerializeField]
	private SpriteReference off; //Field offset: 0x40
	private bool changed; //Field offset: 0x48
	private bool wasOff; //Field offset: 0x49

	private static Btd6Player Player
	{
		private get { } //Length: 7
	}

	public EffectScaleControl() { }

	private void Awake() { }

	private static Btd6Player get_Player() { }

	private void OnDestroy() { }

	public void OnSliderChanged(float value) { }

	public void OnSliderToggle() { }

	private void UpdateVisuals(AccessibilitySettings settings) { }

}

