namespace Assets.Scripts.Simulation;

public static class TimeManager
{
	[CompilerGenerated]
	private static bool <FastForwardActive>k__BackingField; //Field offset: 0x0
	public static bool inBetweenRounds; //Field offset: 0x1
	public static bool gamePaused; //Field offset: 0x2
	public static bool coopPaused; //Field offset: 0x3
	public static bool debugStep; //Field offset: 0x4
	private static double replayTimeScaleMultiplier; //Field offset: 0x8
	private static double timeAtLastSimulate; //Field offset: 0x10
	public static int simulatedFrames; //Field offset: 0x18

	public static double DebugFastForwardMultiplier
	{
		 get { } //Length: 9
	}

	public static bool FastForwardActive
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		 set { } //Length: 83
	}

	public static double FastForwardTimeScale
	{
		 get { } //Length: 66
	}

	public static double TimeSinceLastSimulate
	{
		 get { } //Length: 103
	}

	private static TimeManager() { }

	public static void BeginSimulate() { }

	public static void EndSimulate(double offset) { }

	public static double get_DebugFastForwardMultiplier() { }

	[CompilerGenerated]
	public static bool get_FastForwardActive() { }

	public static double get_FastForwardTimeScale() { }

	public static double get_TimeSinceLastSimulate() { }

	public static void ResetNow() { }

	public static void ResetTimeScale() { }

	[CompilerGenerated]
	public static void set_FastForwardActive(bool value) { }

	public static void SetToNormalSpeed() { }

	public static void SetToReplaySpeed() { }

	public static void Simulate() { }

	public static void Update(bool isCoop, bool reviewMapMode) { }

}

