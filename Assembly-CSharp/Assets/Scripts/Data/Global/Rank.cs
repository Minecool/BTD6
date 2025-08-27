namespace Assets.Scripts.Data.Global;

public class Rank
{
	public long totalXpNeeded; //Field offset: 0x10
	public string levelUnlockString; //Field offset: 0x18

	public Rank() { }

	public string GetHero() { }

	public int GetMM() { }

	public TowerSet GetTower() { }

	public bool HasHero() { }

	public bool HasKnowledge() { }

	public bool HasMM() { }

	public bool HasTower() { }

}

