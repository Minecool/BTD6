namespace Assets.Scripts.Models.Gameplay.Mods;

public class IncomeSetModModel : MutatorModModel
{
	public string incomesetName; //Field offset: 0x30

	public IncomeSetModModel(string name, string incomesetName) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

