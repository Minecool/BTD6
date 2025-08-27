namespace Assets.Scripts.Models.Gameplay.Mods;

public class LockTowerModModel : MutatorModModel
{
	public string towerToLock; //Field offset: 0x30

	public LockTowerModModel(string name, string towerToLock) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

