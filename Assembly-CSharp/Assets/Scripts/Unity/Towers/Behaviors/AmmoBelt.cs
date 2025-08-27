namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AmmoBelt : TowerBehavior
{
	public AmmoBelt parent; //Field offset: 0x98
	public int startCount; //Field offset: 0xA0
	public string expStartCount; //Field offset: 0xA8
	public int maxCount; //Field offset: 0xB0
	public string expMaxCount; //Field offset: 0xB8
	public float regenRate; //Field offset: 0xC0
	public string expRegenRate; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public AmmoBelt() { }

	public virtual TowerBehaviorModel get_Def() { }

}

