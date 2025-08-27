namespace Assets.Scripts.Unity.Achievements;

public class ActiveAchievement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Btd6Player player; //Field offset: 0x10
		public ActiveAchievement <>4__this; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <UpdateExternalComplete>b__0(int _) { }

	}

	private Achievement achievementModel; //Field offset: 0x10
	private float currentProgress; //Field offset: 0x18
	private bool claimed; //Field offset: 0x1C

	public bool Claimed
	{
		 get { } //Length: 5
	}

	public float CurrentProgress
	{
		 get { } //Length: 6
		 set { } //Length: 475
	}

	public float CurrentProgressPercent
	{
		 get { } //Length: 40
	}

	public string Description
	{
		 get { } //Length: 358
	}

	public string EnglishName
	{
		 get { } //Length: 336
	}

	public int Goal
	{
		 get { } //Length: 26
	}

	public bool Hidden
	{
		 get { } //Length: 27
	}

	public int Id
	{
		 get { } //Length: 26
	}

	public bool IsGifted
	{
		 get { } //Length: 127
		 set { } //Length: 127
	}

	private ILocProvider Loc
	{
		private get { } //Length: 48
	}

	public string Name
	{
		 get { } //Length: 308
	}

	public string SteamStatName
	{
		 get { } //Length: 27
	}

	public string Subscript
	{
		 get { } //Length: 27
	}

	public bool Visible
	{
		 get { } //Length: 61
	}

	public bool WasAchieved
	{
		 get { } //Length: 182
	}

	public ActiveAchievement() { }

	public void ApplySprite(Image img, bool useHidden = false) { }

	public void ClaimAchievement() { }

	public bool get_Claimed() { }

	public float get_CurrentProgress() { }

	public float get_CurrentProgressPercent() { }

	public string get_Description() { }

	public string get_EnglishName() { }

	public int get_Goal() { }

	public bool get_Hidden() { }

	public int get_Id() { }

	public bool get_IsGifted() { }

	private ILocProvider get_Loc() { }

	public string get_Name() { }

	public string get_SteamStatName() { }

	public string get_Subscript() { }

	public bool get_Visible() { }

	public bool get_WasAchieved() { }

	public LootSet GetLootSet() { }

	public void MarkAsClaimed() { }

	public override void OnGameStartBeforeLoadingSave() { }

	public override void OnShowVictory() { }

	public void set_CurrentProgress(float value) { }

	public void set_IsGifted(bool value) { }

	public override void SetAchievementModel(Achievement achievement) { }

	public void SetProgressFromData(float currentProgress) { }

	private void UpdateExternalComplete() { }

	public void UpdateExternalStat() { }

	public override void UpdateProgress(Btd6Player player, AnalyticsKonFuze analyticsInfo) { }

}

