namespace Assets.Scripts.Unity.UI_New.Utils;

[RequireComponent(typeof(Canvas), typeof(CanvasScaler), typeof(RectTransform))]
public class RatioCanvasScaler : MonoBehaviour
{
	internal sealed class OnCanvasEnabled : MulticastDelegate
	{

		public OnCanvasEnabled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Canvas canvas, bool enabled, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Canvas canvas, bool enabled) { }

	}

	internal enum VisionOSRenderMode
	{
		WorldSpace = 0,
		ScreenSpace = 1,
	}

	private static Vector2 REFRESO; //Field offset: 0x0
	private static Vector2 REFRESO4x3; //Field offset: 0x8
	private static Vector2 REFRESOSTEAM; //Field offset: 0x10
	private static Vector2 REFRESOSTEAM4x3; //Field offset: 0x18
	private RectTransform rectTransform; //Field offset: 0x20
	private CanvasScaler canvasScaler; //Field offset: 0x28
	[SerializeField]
	private VisionOSRenderMode visionOSRenderMode; //Field offset: 0x30
	[SerializeField]
	private Vector3 visionOSRenderOffset; //Field offset: 0x34

	private static RatioCanvasScaler() { }

	public RatioCanvasScaler() { }

	private void AdjustRefResolution() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnRectTransformDimensionsChange() { }

}

