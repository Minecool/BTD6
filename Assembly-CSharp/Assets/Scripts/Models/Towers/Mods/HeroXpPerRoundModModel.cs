namespace Assets.Scripts.Models.Towers.Mods;

public class HeroXpPerRoundModModel : MutatorModModel
{
	public float additionalXpBonus; //Field offset: 0x30
	public bool applyGlobally; //Field offset: 0x34

	public HeroXpPerRoundModModel(string name, float additionalXpBonus, bool applyGlobally) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

