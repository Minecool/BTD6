namespace Assets.Scripts.Data.Global;

public class RankInfo : ScriptableObject
{
	[SerializeField]
	private List<Rank> rankInfo; //Field offset: 0x18
	public int xpNeededPerVeteranRank; //Field offset: 0x20

	public IEnumerable<Rank> Ranks
	{
		 get { } //Length: 5
	}

	public RankInfo() { }

	public IEnumerable<Rank> get_Ranks() { }

	public int GetHeroUnlockLevel(string heroId) { }

	public int GetMaxRank() { }

	public Rank GetRankInfo(int rank) { }

	public long GetXpDiffForRankFromPrev(int rank) { }

}

