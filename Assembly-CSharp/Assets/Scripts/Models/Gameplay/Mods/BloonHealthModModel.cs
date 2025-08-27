namespace Assets.Scripts.Models.Gameplay.Mods;

public class BloonHealthModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30
	public float addition; //Field offset: 0x34
	public string targets; //Field offset: 0x38

	public BloonHealthModModel(string name, float multiplier, float addition) { }

	public virtual Model Clone() { }

	private bool ModBloon(BloonModel bloon) { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

