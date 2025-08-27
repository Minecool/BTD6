namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "RandomAngleOffset", menuName = "BTD6/Behaviors/Weapons/RandomAngleOffset")]
public class RandomAngleOffset : WeaponBehavior
{
	public int minOffset; //Field offset: 0x30
	public int maxOffset; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 126
	}

	public RandomAngleOffset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

