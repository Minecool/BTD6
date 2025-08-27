namespace Assets.Scripts.Models.Gameplay.Mods;

public class LockTowerSetModModel : MutatorModModel
{
	public TowerSet towerSetToLock; //Field offset: 0x30

	public LockTowerSetModModel(string name, TowerSet towerSetToLock) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

