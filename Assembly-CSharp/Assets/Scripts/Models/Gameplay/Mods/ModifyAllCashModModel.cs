namespace Assets.Scripts.Models.Gameplay.Mods;

public class ModifyAllCashModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30

	public ModifyAllCashModModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	public virtual bool IsGameModeMod() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

	public float ScaleAmount(float cost) { }

}

