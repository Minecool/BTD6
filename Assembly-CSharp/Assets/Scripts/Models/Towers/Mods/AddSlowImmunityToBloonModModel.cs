namespace Assets.Scripts.Models.Towers.Mods;

public class AddSlowImmunityToBloonModModel : MutatorModModel
{
	public string targets; //Field offset: 0x30
	public bool excludeMoabs; //Field offset: 0x38

	public AddSlowImmunityToBloonModModel(string name, string targets, bool excludeMoabs) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

