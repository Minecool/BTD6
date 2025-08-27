namespace Assets.Scripts.Unity.Audio;

public class AudioFactory : MonoBehaviour
{
	[CompilerGenerated]
	private struct <ExecuteTask>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AudioTask audioTask; //Field offset: 0x28
		public AudioFactory <>4__this; //Field offset: 0x30
		private AsyncOperationHandle<AudioClip> <handle>5__2; //Field offset: 0x38
		private TaskAwaiter<AudioClip> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int startingNumOfSources = 20; //Field offset: 0x0
	private const int maxNumOfSources = 200; //Field offset: 0x0
	private const int sourceIncrementAmount = 20; //Field offset: 0x0
	private readonly Dictionary<AudioClipReference, AsyncOperationHandle`1<AudioClip>> audioClipHandles; //Field offset: 0x20
	private readonly List<AudioSource> audioSources; //Field offset: 0x28
	private readonly Dictionary<String, AudioSource> audioSourcesByUniqueId; //Field offset: 0x30
	private readonly Dictionary<String, List`1<AudioSource>> audioSourcesByGroupId; //Field offset: 0x38
	private readonly List<AudioTask> delayedAudioTasks; //Field offset: 0x40
	private readonly List<AudioTask> delayedAudioTasksToExecute; //Field offset: 0x48
	public AudioMixerGroup musicMixer; //Field offset: 0x50
	public AudioMixerGroup fxMixer; //Field offset: 0x58
	public MusicFader musicFader; //Field offset: 0x60
	public InGameMusicFactory musicFactory; //Field offset: 0x68
	public AudioSource musicAudioSource; //Field offset: 0x70
	public Action<String> OnSwitchMusicTrack; //Field offset: 0x78
	private int currentTrackIndex; //Field offset: 0x80
	private float timeLast; //Field offset: 0x84
	private int executionIndex; //Field offset: 0x88

	public AudioFactory() { }

	private void Awake() { }

	public void ChangeMusicVolume(float volume) { }

	public void ChangeSoundFromUnity(AudioClip audioClip, string groupId = "", float volume = 1, bool unique = false, string uniqueId = null, bool loop = false, bool play = true, bool stop = false, bool pause = false, bool pauseState = false, AudioType audioType = 0) { }

	public void CleanUp() { }

	private void CreateStartingSources() { }

	public void DestroyInGameMusicFactory() { }

	[AsyncStateMachine(typeof(<ExecuteTask>d__28))]
	private void ExecuteTask(AudioTask audioTask) { }

	public void ExecuteTasks(List<AudioTask> audioTasks) { }

	public void FadeMusic() { }

	private AudioSource FindFreeSource(AudioTask audioTask) { }

	public AudioSource FindSourceByUniqueId(string uniqueId) { }

	public int GetLatestTrackIndex() { }

	public float GetMusicVolume() { }

	public void InitMusicFactory(string mapTrack) { }

	public void InitMusicSource() { }

	public void MuteMusic(bool mute) { }

	private void OnAudioConfigurationChanged(bool deviceWasChanged) { }

	private void OnDestroy() { }

	private void OnPlayerLoaded(Btd6Player player) { }

	public void PlayMusic(AudioClip clip) { }

	public void PlayMusicFromClipName(string musicName) { }

	public void PlaySound(AudioClipReference audioClipRef, string groupId, int groupLimit = -1, float volume = 1, float delay = 0, bool unique = false, string uniqueId = null, bool loop = false, bool stop = false, bool play = true, AudioType audioType = 0) { }

	public void PlaySoundFromUnity(AudioClip audioClip, string groupId, int groupLimit = -1, float volume = 1, float delay = 0, bool unique = false, string uniqueId = null, bool loop = false, bool stop = false, bool play = true, AudioType audioType = 0) { }

	private void RemoveSourceFromGroupList(AudioSource audioSource) { }

	private void RemoveSourceFromUniqueList(AudioSource audioSource) { }

	public void SetLatestTrackIndex(int newIndex) { }

	private void Start() { }

	public void StopMusic() { }

	public void Update() { }

	private void UpdateDelayedTasks(float delta) { }

	private void UpdateGroup(AudioTask audioTask, AudioSource audioSource) { }

	private void UpdateUniqueSource(AudioTask audioTask, AudioSource audioSource) { }

}

