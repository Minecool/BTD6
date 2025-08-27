namespace Assets.Scripts.Models.Gameplay.Mods;

public class SetHealthForBloonModModel : MutatorModModel
{
	public int round; //Field offset: 0x30
	[BloonType]
	public string bloonId; //Field offset: 0x38
	public float healthMultiplier; //Field offset: 0x40
	public string gameMode; //Field offset: 0x48

	public SetHealthForBloonModModel(string name, int round, string bloonId, float healthMultiplier, string gameMode) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

