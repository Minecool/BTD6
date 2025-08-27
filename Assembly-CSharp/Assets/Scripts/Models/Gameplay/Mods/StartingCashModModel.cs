namespace Assets.Scripts.Models.Gameplay.Mods;

public class StartingCashModModel : MutatorModModel
{
	public float changeBase; //Field offset: 0x30
	public float addition; //Field offset: 0x34
	public float multiplier; //Field offset: 0x38

	public StartingCashModModel(string name, float changeBase, float addition, float multiplier) { }

	public virtual Model Clone() { }

}

