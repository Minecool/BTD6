namespace Unity.Services.Analytics;

internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer
{
	private const float k_AutoFlushPeriod = 60; //Field offset: 0x0
	private const float k_GameRunningPeriod = 60; //Field offset: 0x0
	private static bool s_Created; //Field offset: 0x0
	private static GameObject s_Container; //Field offset: 0x8
	[CompilerGenerated]
	private static AnalyticsContainer <Instance>k__BackingField; //Field offset: 0x10
	private float m_AutoFlushTime; //Field offset: 0x20
	private float m_GameRunningTime; //Field offset: 0x24
	private AnalyticsServiceInstance m_Service; //Field offset: 0x28

	private float AutoFlushPeriod
	{
		private get { } //Length: 116
	}

	internal static AnalyticsContainer Instance
	{
		[CompilerGenerated]
		internal get { } //Length: 55
		[CompilerGenerated]
		private set { } //Length: 61
	}

	internal float TimeUntilHeartbeat
	{
		internal get { } //Length: 27
	}

	public AnalyticsContainer() { }

	internal static AnalyticsContainer CreateContainer() { }

	public override void Disable() { }

	public override void Enable() { }

	private float get_AutoFlushPeriod() { }

	[CompilerGenerated]
	internal static AnalyticsContainer get_Instance() { }

	internal float get_TimeUntilHeartbeat() { }

	public override void Initialize(AnalyticsServiceInstance service) { }

	private void OnApplicationPause(bool paused) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private static void set_Instance(AnalyticsContainer value) { }

	private void Update() { }

}

