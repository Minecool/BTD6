namespace Assets.Scripts.Unity.Feats;

public abstract class LegendsFeatActive
{
	private LegendsFeatData legendsFeatData; //Field offset: 0x10
	private int currentProgress; //Field offset: 0x18
	private bool claimed; //Field offset: 0x1C

	public bool Claimed
	{
		 get { } //Length: 5
	}

	public int CurrentProgress
	{
		 get { } //Length: 4
		 set { } //Length: 167
	}

	public float CurrentProgressPercent
	{
		 get { } //Length: 43
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

	private ILocProvider Loc
	{
		private get { } //Length: 48
	}

	public string Name
	{
		 get { } //Length: 308
	}

	public string Subscript
	{
		 get { } //Length: 27
	}

	public bool Visible
	{
		 get { } //Length: 55
	}

	public bool WasAchieved
	{
		 get { } //Length: 45
	}

	protected LegendsFeatActive() { }

	public void ApplySprite(Image img, bool useHidden = false) { }

	public void ClaimFeat() { }

	public void ClearProgress() { }

	public bool get_Claimed() { }

	public int get_CurrentProgress() { }

	public float get_CurrentProgressPercent() { }

	public string get_Description() { }

	public string get_EnglishName() { }

	public int get_Goal() { }

	public bool get_Hidden() { }

	public int get_Id() { }

	private ILocProvider get_Loc() { }

	public string get_Name() { }

	public string get_Subscript() { }

	public bool get_Visible() { }

	public bool get_WasAchieved() { }

	public LegendsFeatData GetLegendsFeatData() { }

	public void MarkAsClaimed() { }

	public void set_CurrentProgress(int value) { }

	public void SetLegendsFeatData(LegendsFeatData legendsFeatData) { }

	public void SetUnclaimed() { }

	public abstract void UpdateProgress(LegendsStats stats) { }

}

