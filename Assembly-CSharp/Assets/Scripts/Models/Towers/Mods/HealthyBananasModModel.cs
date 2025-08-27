namespace Assets.Scripts.Models.Towers.Mods;

public class HealthyBananasModModel : MutatorModModel
{
	public int marketplaceLives; //Field offset: 0x30
	public int centralMarketLives; //Field offset: 0x34
	public PrefabReference displayPath; //Field offset: 0x38
	public float displayLifespan; //Field offset: 0x40

	public HealthyBananasModModel(string name, int marketplaceBonus, int centralMarketLives, PrefabReference displayPath, float displayLifespan) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

