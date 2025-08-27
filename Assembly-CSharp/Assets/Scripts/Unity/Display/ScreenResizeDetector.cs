namespace Assets.Scripts.Unity.Display;

public class ScreenResizeDetector : MonoBehaviourSingleton<ScreenResizeDetector>
{
	private OnScreenSizeChange onScreenSizeChanged; //Field offset: 0x20
	private int currentWidth; //Field offset: 0x28
	private int currentHeight; //Field offset: 0x2C

	public ScreenResizeDetector() { }

	public static void Register(OnScreenSizeChange handler) { }

	public static void Unregister(OnScreenSizeChange handler) { }

	private void Update() { }

}

