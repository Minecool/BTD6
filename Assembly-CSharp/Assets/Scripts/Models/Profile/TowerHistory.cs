namespace Assets.Scripts.Models.Profile;

public class TowerHistory
{
	public string uniqueId; //Field offset: 0x10
	public string baseId; //Field offset: 0x18
	public TowerSet towerSet; //Field offset: 0x20
	public Int32[] tiers; //Field offset: 0x28
	public float cost; //Field offset: 0x30
	public bool destroyed; //Field offset: 0x34
	public int tiersModifier; //Field offset: 0x38

	public TowerHistory(string uniqueId, string baseId, TowerSet towerSet, Int32[] tiers, float cost) { }

	public TowerHistory Clone() { }

	public static int TiersUsed(List<TowerHistory> towerHistory) { }

}

