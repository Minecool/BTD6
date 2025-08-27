namespace Assets.Scripts.Models.Towers.Mods;

public class FreeTowerModModel : MutatorModModel
{
	public string baseTowerID; //Field offset: 0x30
	public int charges; //Field offset: 0x38
	public string mutuallyExclusiveWith; //Field offset: 0x40
	public int priority; //Field offset: 0x48

	public FreeTowerModModel(string name, string baseTowerID, int charges, string mutuallyExclusiveWith, int priority) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

