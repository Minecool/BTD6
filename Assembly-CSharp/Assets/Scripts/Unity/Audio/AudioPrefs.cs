namespace Assets.Scripts.Unity.Audio;

public static class AudioPrefs
{
	private interface IPreferenceInterface
	{

		public bool IsAvailable
		{
			 get { } //Length: 0
		}

		public bool NeedsSave
		{
			 get { } //Length: 0
		}

		public bool get_IsAvailable() { }

		public bool get_NeedsSave() { }

		public bool GetBool(string key, bool defaultValue = false) { }

		public float GetFloat(string key, float defaultValue = 0) { }

		public void Save() { }

		public void SetBool(string key, bool value) { }

		public void SetFloat(string key, float value) { }

	}

	private class PlayerPrefsInterface : IPreferenceInterface
	{
		[CompilerGenerated]
		private bool <NeedsSave>k__BackingField; //Field offset: 0x10

		public override bool IsAvailable
		{
			 get { } //Length: 3
		}

		public private override bool NeedsSave
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public PlayerPrefsInterface() { }

		public override bool get_IsAvailable() { }

		[CompilerGenerated]
		public override bool get_NeedsSave() { }

		public override bool GetBool(string key, bool defaultValue = false) { }

		public override float GetFloat(string key, float defaultValue = 0) { }

		public override void Save() { }

		[CompilerGenerated]
		private void set_NeedsSave(bool value) { }

		public override void SetBool(string key, bool value) { }

		public override void SetFloat(string key, float value) { }

	}

	private class PlayerProfileInterface : IPreferenceInterface
	{
		[CompilerGenerated]
		private bool <NeedsSave>k__BackingField; //Field offset: 0x10
		private readonly ProfileModel profileModel; //Field offset: 0x18

		private AudioSettings AudioSettings
		{
			private get { } //Length: 96
		}

		public override bool IsAvailable
		{
			 get { } //Length: 103
		}

		public private override bool NeedsSave
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public PlayerProfileInterface(ProfileModel profileModel = null) { }

		private AudioSettings get_AudioSettings() { }

		public override bool get_IsAvailable() { }

		[CompilerGenerated]
		public override bool get_NeedsSave() { }

		public override bool GetBool(string key, bool defaultValue = false) { }

		public override float GetFloat(string key, float defaultValue = 0) { }

		public override void Save() { }

		[CompilerGenerated]
		private void set_NeedsSave(bool value) { }

		public override void SetBool(string key, bool value) { }

		public override void SetFloat(string key, float value) { }

	}

	private const string kLogTag = "<color=#f79e4d>[AudioPrefs]</color>"; //Field offset: 0x0
	public const string kFxKey = "fx"; //Field offset: 0x0
	public const string kMusicKey = "music"; //Field offset: 0x0
	public const string kHeroVoKey = "heroVO"; //Field offset: 0x0
	public const string kPetSoundsKey = "petSounds"; //Field offset: 0x0
	private const string kMutedKeyPostfix = "Muted"; //Field offset: 0x0
	private const string kVolumeKeyPostfix = "Modifier"; //Field offset: 0x0
	private const string kLoopTrack = "loopTrack"; //Field offset: 0x0
	private const string kShufflePlaylist = "shufflePlaylist"; //Field offset: 0x0
	private static IPreferenceInterface[] interfaces; //Field offset: 0x0

	public static bool FxMuted
	{
		 get { } //Length: 83
	}

	public static float FxVolume
	{
		 get { } //Length: 83
	}

	public static bool HeroVOMuted
	{
		 get { } //Length: 83
	}

	public static float HeroVOVolume
	{
		 get { } //Length: 83
	}

	public static bool LoopTrack
	{
		 get { } //Length: 86
		 set { } //Length: 93
	}

	public static bool MusicMuted
	{
		 get { } //Length: 83
	}

	public static float MusicVolume
	{
		 get { } //Length: 83
	}

	public static bool PetSoundsMuted
	{
		 get { } //Length: 83
	}

	public static bool ShufflePlaylist
	{
		 get { } //Length: 86
		 set { } //Length: 93
	}

	private static AudioPrefs() { }

	public static void CopyPlayerPrefsToProfile(ProfileModel profileModel) { }

	public static void CopyProfileToPlayerPrefs(ProfileModel profileModel) { }

	private static void CopySettings(IPreferenceInterface a, IPreferenceInterface b) { }

	public static void Flush() { }

	public static bool get_FxMuted() { }

	public static float get_FxVolume() { }

	public static bool get_HeroVOMuted() { }

	public static float get_HeroVOVolume() { }

	public static bool get_LoopTrack() { }

	public static bool get_MusicMuted() { }

	public static float get_MusicVolume() { }

	public static bool get_PetSoundsMuted() { }

	public static bool get_ShufflePlaylist() { }

	private static bool GetBool(string key, bool defaultValue = false) { }

	private static float GetFloat(string key, float defaultValue = 0) { }

	public static float GetVolume(string key) { }

	public static bool IsMuted(string key) { }

	public static string MutedKeyFor(string key) { }

	public static void set_LoopTrack(bool value) { }

	public static void set_ShufflePlaylist(bool value) { }

	private static void SetBool(string key, bool value) { }

	private static void SetFloat(string key, float value) { }

	public static void SetMuted(string key, bool isMuted, bool saveImmediately = true) { }

	public static void SetVolume(string key, float value, bool saveImmediately = true) { }

	public static string VolumeKeyFor(string key) { }

}

