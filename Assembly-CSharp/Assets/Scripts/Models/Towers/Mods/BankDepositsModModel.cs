namespace Assets.Scripts.Models.Towers.Mods;

public class BankDepositsModModel : MutatorModModel
{
	public float depositPercent; //Field offset: 0x30
	public string towerSelectionMenuThemeId; //Field offset: 0x38
	public PrefabReference displayPath; //Field offset: 0x40
	public float displayLifetime; //Field offset: 0x48

	public BankDepositsModModel(string name, float depositPercent, string towerSelectionMenuThemeId, PrefabReference displayPath, float displayLifetime) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

