namespace Assets.Scripts.Models.Gameplay.Mods;

public class UpgradeCostModModel : MutatorModModel
{
	public int amountReduced; //Field offset: 0x30
	public float percentageReduced; //Field offset: 0x34
	public string upgradeName; //Field offset: 0x38

	public UpgradeCostModModel(string name, int amountReduced, float percentageReduced, string upgradeName) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

