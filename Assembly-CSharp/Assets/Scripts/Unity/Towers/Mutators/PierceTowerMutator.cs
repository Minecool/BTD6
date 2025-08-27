namespace Assets.Scripts.Unity.Towers.Mutators;

public class PierceTowerMutator : TowerMutator
{
	public int pierce; //Field offset: 0xB0
	public string expPierce; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 320
	}

	public PierceTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

