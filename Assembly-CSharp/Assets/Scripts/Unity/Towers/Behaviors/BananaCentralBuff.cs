namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BananaCentralBuff : TowerBehaviorGlobalBuff
{
	public BananaCentralBuff parent; //Field offset: 0xC8
	public float multiplier; //Field offset: 0xD0
	public string expMultiplier; //Field offset: 0xD8
	public string mutatorId; //Field offset: 0xE0
	public string expMutatorId; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 191
	}

	public BananaCentralBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

