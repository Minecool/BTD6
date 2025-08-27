namespace Facepunch.Steamworks;

public class Achievements : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Achievement[] old; //Field offset: 0x10
		public Achievements <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal Achievement <Refresh>b__0(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass13_1() { }

		internal bool <Refresh>b__1(Achievement y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public string identifier; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <Find>b__0(Achievement x) { }

	}

	internal Client client; //Field offset: 0x10
	[CompilerGenerated]
	private Achievement[] <All>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnUpdated; //Field offset: 0x20
	[CompilerGenerated]
	private Action<Achievement> OnAchievementStateChanged; //Field offset: 0x28
	private List<Achievement> unlockedRecently; //Field offset: 0x30

	public private Achievement[] All
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal Achievements(Client c) { }

	public override void Dispose() { }

	public Achievement Find(string identifier) { }

	[CompilerGenerated]
	public Achievement[] get_All() { }

	internal void OnUnlocked(Achievement a) { }

	public void Refresh() { }

	[CompilerGenerated]
	private void set_All(Achievement[] value) { }

	private void UserStatsReceived(UserStatsReceived_t stats) { }

	private void UserStatsStored(UserStatsStored_t stats) { }

}

