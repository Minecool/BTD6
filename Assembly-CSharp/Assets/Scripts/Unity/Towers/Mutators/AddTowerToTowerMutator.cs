namespace Assets.Scripts.Unity.Towers.Mutators;

public class AddTowerToTowerMutator : TowerMutator
{
	public Tower tower; //Field offset: 0xB0
	public Tower expTower; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 386
	}

	public AddTowerToTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

