namespace UnityEngine.Playables;

[Extension]
public static class PlayableExtensions
{

	[Extension]
	public static void Destroy(U playable) { }

	[Extension]
	public static double GetTime(U playable) { }

	[Extension]
	public static bool IsValid(U playable) { }

	[Extension]
	public static void Pause(U playable) { }

	[Extension]
	public static void SetInputWeight(U playable, int inputIndex, float weight) { }

	[Extension]
	public static void SetSpeed(U playable, double value) { }

	[Extension]
	public static void SetTime(U playable, double value) { }

}

