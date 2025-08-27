namespace Assets.Scripts.Models.Towers.Mods;

public class EmergencyUnlockModModel : MutatorModModel
{

	public EmergencyUnlockModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

