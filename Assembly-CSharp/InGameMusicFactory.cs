//Type is in global namespace

public class InGameMusicFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<TrackItemData> <>9__44_0; //Field offset: 0x8
		public static Predicate<TrackItemData> <>9__48_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <ChangeMusicOnBossDestroyed>b__44_0(TrackItemData x) { }

		internal bool <ReshufflePlaylist>b__48_0(TrackItemData x) { }

	}

	[CompilerGenerated]
	private List<TrackItemData> <TrackItemDataList>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<TrackItemData> <ShuffledTrackItemDataList>k__BackingField; //Field offset: 0x18
	private AudioFactory audioFactory; //Field offset: 0x20
	private float extraTail; //Field offset: 0x28
	private int currentTrackIndex; //Field offset: 0x2C
	private float currentTrackLength; //Field offset: 0x30
	private bool usePlayList; //Field offset: 0x34
	private string mapTrack; //Field offset: 0x38
	private string mapMusicName; //Field offset: 0x40
	private AudioClip bossMusicClip; //Field offset: 0x48
	[CompilerGenerated]
	private bool <RepeatTrack>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <BossMusicIsPlaying>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	private bool <ShufflePlaylist>k__BackingField; //Field offset: 0x52

	public bool BossMusicIsPlaying
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool RepeatTrack
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private List<TrackItemData> ShuffledTrackItemDataList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool ShufflePlaylist
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private List<TrackItemData> TrackItemDataList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public InGameMusicFactory(string mapTrack, AudioFactory audioFactory) { }

	private void AddBossTrack() { }

	private void AddTrackToTrackList(string trackName) { }

	private void ChangeMusicOnBossDestroyed() { }

	private void ChangeMusicOnBossPresent() { }

	public void CleanUp() { }

	private void FadeCurrentTrack() { }

	[CompilerGenerated]
	public bool get_BossMusicIsPlaying() { }

	[CompilerGenerated]
	public bool get_RepeatTrack() { }

	[CompilerGenerated]
	public List<TrackItemData> get_ShuffledTrackItemDataList() { }

	[CompilerGenerated]
	public bool get_ShufflePlaylist() { }

	[CompilerGenerated]
	public List<TrackItemData> get_TrackItemDataList() { }

	private TrackItemData GetNextTrackItemData(bool bossMusic = false) { }

	private float GetTrackLength() { }

	private float GetTrackPosition() { }

	private void InitMusic() { }

	private bool IsRushGameMode() { }

	private void OnSwitchMusicTrack(string musicId) { }

	private void PlayNewTrack(bool bossMusic = false) { }

	private void PopulateList() { }

	public void ReshufflePlaylist() { }

	[CompilerGenerated]
	public void set_BossMusicIsPlaying(bool value) { }

	[CompilerGenerated]
	public void set_RepeatTrack(bool value) { }

	[CompilerGenerated]
	private void set_ShuffledTrackItemDataList(List<TrackItemData> value) { }

	[CompilerGenerated]
	public void set_ShufflePlaylist(bool value) { }

	[CompilerGenerated]
	private void set_TrackItemDataList(List<TrackItemData> value) { }

	public void SetCurrentTrack(int newIndex) { }

	private void SetUsePlayList() { }

	public void StartInGameMusic() { }

	private void StopCurrentTrack() { }

	public void UpdateMusicFactory() { }

}

