namespace Assets.Scripts.Unity.Towers.Mutators;

public class AddAttackTowerMutator : TowerMutator
{
	public Attack attack; //Field offset: 0xB0
	public Attack expAttack; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 398
	}

	public AddAttackTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

