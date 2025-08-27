namespace Assets.Scripts.Unity.Map.Triggers;

public class PlaySoundUnityAction : MapUnityAction
{
	public List<AudioClip> sounds; //Field offset: 0x28
	[Header("Check Use Audio Sequencer and assign playInteractableAudio if you want perfectly timed audio")]
	public PlayInteractableAudio playInteractableAudio; //Field offset: 0x30
	[Header("Leave unchecked if you just want to play a one-off randomised sound")]
	public bool useAudioSequencer; //Field offset: 0x38
	[Header("Start playing sound on round x + roundOffset")]
	public int roundOffset; //Field offset: 0x3C
	[Header("Play sound every x rounds")]
	public int playOnEveryRound; //Field offset: 0x40
	private bool skipRound; //Field offset: 0x44

	public PlaySoundUnityAction() { }

	public virtual void GotoPostAction() { }

	public virtual void PerformAction() { }

	public void Start() { }

	public virtual void UpdateRound(int round, bool isSet) { }

}

