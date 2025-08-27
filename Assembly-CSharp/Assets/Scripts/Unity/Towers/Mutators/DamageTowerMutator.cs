namespace Assets.Scripts.Unity.Towers.Mutators;

public class DamageTowerMutator : TowerMutator
{
	public float damage; //Field offset: 0xB0
	public string expDamage; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 325
	}

	public DamageTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

