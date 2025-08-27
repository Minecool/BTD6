namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "RandomSpeedOffset", menuName = "BTD6/Behaviors/Weapons/RandomSpeedOffset")]
public class RandomSpeedOffset : WeaponBehavior
{
	public int minOffset; //Field offset: 0x30
	public int maxOffset; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 126
	}

	public RandomSpeedOffset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

