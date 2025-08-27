namespace Assets.Scripts.Simulation.Audio;

internal class AudioLimiter
{
	public string groupLimitId; //Field offset: 0x10
	public int lastPlayedCounter; //Field offset: 0x18
	public int lastPlayedCounterReset; //Field offset: 0x1C
	public bool canPlaySound; //Field offset: 0x20

	public AudioLimiter(string groupLimitId, int lastPlayedCounter, int lastPlayedCounterReset, bool canPlaySound) { }

}

