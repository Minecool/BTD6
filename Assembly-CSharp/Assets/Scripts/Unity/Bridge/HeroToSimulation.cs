namespace Assets.Scripts.Unity.Bridge;

public class HeroToSimulation
{
	private UnityToSimulation sim; //Field offset: 0x10
	private Tower tower; //Field offset: 0x18
	private Hero hero; //Field offset: 0x20

	public float costToLevelUp
	{
		 get { } //Length: 29
	}

	public float cumulativeXp
	{
		 get { } //Length: 28
	}

	public int level
	{
		 get { } //Length: 52
	}

	public int maxLevel
	{
		 get { } //Length: 29
	}

	public float relativeXp
	{
		 get { } //Length: 28
	}

	public float relativeXpForNextLevel
	{
		 get { } //Length: 29
	}

	public HeroToSimulation(UnityToSimulation sim, Tower tower, Hero hero) { }

	public float get_costToLevelUp() { }

	public float get_cumulativeXp() { }

	public int get_level() { }

	public int get_maxLevel() { }

	public float get_relativeXp() { }

	public float get_relativeXpForNextLevel() { }

	public void PurchaseHeroMaxLevelUp(Action<Boolean> callback) { }

	public void PurchaseLevelUp(Action<Boolean> callback) { }

	public void UpgradeToLevel(int levelToUpgradeTo, Action<Boolean> callback) { }

}

