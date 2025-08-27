namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "RandomRate", menuName = "BTD6/Behaviors/Weapons/RandomRate")]
public class RandomRate : WeaponBehavior
{
	public float rateOffset; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public RandomRate() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

