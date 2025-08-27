namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PrinceOfDarknessZombieBuff : TowerBehaviorGlobalBuff
{
	public PrinceOfDarknessZombieBuff parent; //Field offset: 0xC8
	public float damageIncrease; //Field offset: 0xD0
	public string expDamageIncrease; //Field offset: 0xD8
	public float distanceMultiplier; //Field offset: 0xE0
	public string expDistanceMultiplier; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 203
	}

	public PrinceOfDarknessZombieBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

