namespace Assets.Scripts.Simulation.Audio;

public class AudioManagerSim : RootBehavior
{
	public readonly List<AudioTask> audioTasks; //Field offset: 0x58

	public AudioManagerSim() { }

	protected virtual void OnDestroy() { }

	public void PlaySound(AudioClipReference audioClipRef, bool loop = false, bool unique = false, string uniqueId = "", float volume = 1, float pitch = 1, float delay = -1, string groupId = "", int groupLimit = -1, AudioType audioType = 0) { }

}

