namespace Assets.Scripts.Unity.Towers.Mutators;

public class AddBehaviorToTowerMutator : TowerMutator
{
	public float lifespan; //Field offset: 0xB0
	public string expLifespan; //Field offset: 0xB8
	public TowerBehavior behavior; //Field offset: 0xC0

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 454
	}

	public AddBehaviorToTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

