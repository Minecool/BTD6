namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class Hero : TowerBehavior
{
	public HeroModel heroModel; //Field offset: 0x68
	public UpgradeModel upgrade; //Field offset: 0x70
	public float xp; //Field offset: 0x78
	public float totalXp; //Field offset: 0x7C
	public float xpBonus; //Field offset: 0x80
	public int maxLevel; //Field offset: 0x84
	public int levelsGainedThisRound; //Field offset: 0x88

	public Hero() { }

	public void AddXp(float amount) { }

	private void CalcMaxLevel() { }

	private void CheckForLevelUp() { }

	public float GetCostToLevelUp() { }

	public int GetHeroLevel() { }

	private TowerModel GetTowerModel(string id) { }

	public float GetXPForNextLevel() { }

	private float GetXPToLevel() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void PostEndOfRoundAddXp() { }

	public bool PurchaseHeroLevelUp(int inputId = -1) { }

	public bool PurchaseMaxHeroLevel(int inputId = -1) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public bool UpgradeToLevel(int level, int inputId, bool playUpgradeEffect = true, bool dontCountTiers = false) { }

}

