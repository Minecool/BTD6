namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DruidOfWrathBuff : TowerBehavior
{
	public DruidOfWrathBuff parent; //Field offset: 0x98
	public int newPopCount; //Field offset: 0xA0
	public string expNewPopCount; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public DruidOfWrathBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

