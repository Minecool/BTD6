namespace Assets.Scripts.Models.Gameplay.Mods;

public class MonkeyMoneyModModel : MutatorModModel
{
	public float changeBase; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34

	public MonkeyMoneyModModel(string name, float changeBase, float multiplier) { }

	public virtual Model Clone() { }

	public float Mod(float value) { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

