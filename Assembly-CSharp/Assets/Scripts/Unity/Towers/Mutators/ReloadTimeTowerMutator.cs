namespace Assets.Scripts.Unity.Towers.Mutators;

public class ReloadTimeTowerMutator : TowerMutator
{
	public float multiplier; //Field offset: 0xB0
	public string expMultiplier; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 325
	}

	public ReloadTimeTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

