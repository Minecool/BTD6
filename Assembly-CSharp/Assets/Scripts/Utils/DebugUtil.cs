namespace Assets.Scripts.Utils;

public static class DebugUtil
{
	internal sealed class OnUIToggled : MulticastDelegate
	{

		public OnUIToggled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private static TurnOffOnRelease[] scripts1; //Field offset: 0x0
	private const float accelerometerUpdateInterval = 0.016666668; //Field offset: 0x0
	private const float lowPassKernelWidthInSeconds = 1; //Field offset: 0x0
	private const float shakeDetectionThreshold = 2; //Field offset: 0x0
	private const float lowPassFilterFactor = 0.016666668; //Field offset: 0x0
	private static TurnOffComponentOnRelease[] scripts2; //Field offset: 0x8
	private static bool isVisibile; //Field offset: 0x10
	private static Vector3 lowPassValue; //Field offset: 0x14
	private static float lastShake; //Field offset: 0x20

	public static bool IsVisible
	{
		 get { } //Length: 79
	}

	private static DebugUtil() { }

	public static bool get_IsVisible() { }

	private static void ToggleHide() { }

	private static void ToggleLanguage() { }

	private static void ToggleUI() { }

	public static void Update() { }

}

