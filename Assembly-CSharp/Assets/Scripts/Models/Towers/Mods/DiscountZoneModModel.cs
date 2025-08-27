namespace Assets.Scripts.Models.Towers.Mods;

public class DiscountZoneModModel : MutatorModModel
{
	public float additionalMultiplier; //Field offset: 0x30
	public string specificScriptId; //Field offset: 0x38

	public DiscountZoneModModel(string name, float additionalMultiplier, string specificScriptId) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

