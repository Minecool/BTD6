namespace Assets.Scripts.Data.Feats;

public class LegendsFeatsData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public LegendType type; //Field offset: 0x10
		public Func<LegendsFeatActive, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal bool <GetFeatsClaimed>b__0(LegendsFeatActive x) { }

	}

	[SerializeField]
	public List<LegendsFeatData> featDatas; //Field offset: 0x18
	public readonly List<LegendsFeatActive> activeFeats; //Field offset: 0x20

	public LegendsFeatsData() { }

	public void CheckFeatProgress(LegendsStats stats) { }

	public void ClaimFeat(int featId) { }

	public void ClearFeatProgress() { }

	public LegendsFeatActive GetActiveFeat(int featId) { }

	public LegendsFeatData GetFeat(string featName) { }

	public LegendsFeatData GetFeat(int featId) { }

	public int GetFeatsClaimed(LegendType type = 0) { }

	public int GetTotalFeatsClaimed() { }

	public void Initialise() { }

	public void MaxFeatProgress(int featId) { }

}

