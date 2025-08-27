namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ParagonSacrificeBonus : TowerBehavior
{
	public ParagonSacrificeBonus parent; //Field offset: 0x98
	public float bonus; //Field offset: 0xA0
	public string expBonus; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public ParagonSacrificeBonus() { }

	public virtual TowerBehaviorModel get_Def() { }

}

