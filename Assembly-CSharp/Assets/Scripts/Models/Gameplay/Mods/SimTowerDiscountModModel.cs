namespace Assets.Scripts.Models.Gameplay.Mods;

public class SimTowerDiscountModModel : MutatorModModel
{
	public string tower; //Field offset: 0x30
	public bool useAllHeroes; //Field offset: 0x38
	public float multiplier; //Field offset: 0x3C
	public float subtraction; //Field offset: 0x40
	public int charges; //Field offset: 0x44

	public SimTowerDiscountModModel(string name, string tower, bool useAllHeroes, float multiplier, float subtraction, int charges) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

