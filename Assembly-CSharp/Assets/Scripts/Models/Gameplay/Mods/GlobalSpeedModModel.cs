namespace Assets.Scripts.Models.Gameplay.Mods;

public class GlobalSpeedModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30
	public float addition; //Field offset: 0x34

	public GlobalSpeedModModel(string name, float multiplier, float addition) { }

	public virtual Model Clone() { }

	private bool ModBloon(BloonModel bloon) { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

