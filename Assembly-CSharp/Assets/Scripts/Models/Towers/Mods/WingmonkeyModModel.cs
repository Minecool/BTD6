namespace Assets.Scripts.Models.Towers.Mods;

public class WingmonkeyModModel : MutatorModModel
{
	public WingmonkeyPatternModel wingmonkeyPatternModel; //Field offset: 0x30

	public WingmonkeyModModel(string name, WingmonkeyPatternModel wingmonkeyPatternModel) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

