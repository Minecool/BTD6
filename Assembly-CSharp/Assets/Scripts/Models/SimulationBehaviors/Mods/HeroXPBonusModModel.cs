namespace Assets.Scripts.Models.SimulationBehaviors.Mods;

public class HeroXPBonusModModel : MutatorModModel
{
	public float percentMultiplier; //Field offset: 0x30

	public HeroXPBonusModModel(string name, float percentMultiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

