namespace Assets.Scripts.Models.Gameplay.Mods;

public class ModifyPopCashModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30

	public ModifyPopCashModModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	public virtual bool IsGameModeMod() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

	public float ScaleAmount(float cost) { }

}

