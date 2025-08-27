namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PrinceOfDarknessZombieBuff", menuName = "BTD6/Behaviors/Towers/PrinceOfDarknessZombieBuff")]
public class PrinceOfDarknessZombieBuff : TowerBehaviorGlobalBuff
{
	public float damageIncrease; //Field offset: 0x40
	public float distanceMultiplier; //Field offset: 0x44

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public PrinceOfDarknessZombieBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

