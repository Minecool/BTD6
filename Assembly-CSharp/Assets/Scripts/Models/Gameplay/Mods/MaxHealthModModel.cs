namespace Assets.Scripts.Models.Gameplay.Mods;

public class MaxHealthModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30
	public float addition; //Field offset: 0x34
	public float set; //Field offset: 0x38

	public MaxHealthModModel(string name, float multiplier, float addition, float set) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

