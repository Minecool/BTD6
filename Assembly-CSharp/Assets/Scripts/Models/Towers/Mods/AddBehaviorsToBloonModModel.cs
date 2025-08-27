namespace Assets.Scripts.Models.Towers.Mods;

public class AddBehaviorsToBloonModModel : MutatorModModel
{
	public string targets; //Field offset: 0x30
	public bool excludeMoabs; //Field offset: 0x38
	[SerializeReference]
	private BloonBehaviorModel[] behaviors; //Field offset: 0x40

	public AddBehaviorsToBloonModModel(string name, string targets, bool excludeMoabs, BloonBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

