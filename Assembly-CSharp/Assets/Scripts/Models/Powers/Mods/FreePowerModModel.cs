namespace Assets.Scripts.Models.Powers.Mods;

public class FreePowerModModel : MutatorModModel
{
	public string basePowerID; //Field offset: 0x30
	public int charges; //Field offset: 0x38

	public FreePowerModModel(string name, string basePowerID, int charges) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

