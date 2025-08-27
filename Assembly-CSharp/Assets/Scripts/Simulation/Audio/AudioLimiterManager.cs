namespace Assets.Scripts.Simulation.Audio;

public class AudioLimiterManager : RootBehavior
{
	private Dictionary<String, AudioLimiter> audioLimiters; //Field offset: 0x58
	private Dictionary<String, Dictionary`2<String, String>> groupIdLookup; //Field offset: 0x60

	public AudioLimiterManager() { }

	public string GroupIdLookup(string groupStr, string subGroupStr) { }

	public void InitAudioLimiter() { }

	protected virtual void OnDestroy() { }

	private void OnRoundStart(int spawnedRound) { }

	public void PlaySound(AudioClipReference soundId, bool loop = false, bool unique = false, string uniqueId = "", float volume = 1, string groupId = "", string groupLimitId = "", int groupLimit = -1, int limitCounter = 600, float delay = -1, AudioType audioType = 0) { }

	private void Process(int elapsed) { }

	private void ResetCounters() { }

}

