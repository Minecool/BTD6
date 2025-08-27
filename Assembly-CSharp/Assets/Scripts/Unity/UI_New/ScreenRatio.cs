namespace Assets.Scripts.Unity.UI_New;

public struct ScreenRatio
{
	private const float kDefaultVariance = 0.01; //Field offset: 0x0
	private readonly float aspectRatio; //Field offset: 0x0

	public bool IsOrOver14x9
	{
		 get { } //Length: 23
	}

	public bool IsOrOver18x9
	{
		 get { } //Length: 23
	}

	private ScreenRatio(float aspect) { }

	public bool get_IsOrOver14x9() { }

	public bool get_IsOrOver18x9() { }

	public static ScreenRatio GetCurrent() { }

	private bool IsEqualOrGreater(float x) { }

	public ScreenRatioType ToRatioType() { }

}

