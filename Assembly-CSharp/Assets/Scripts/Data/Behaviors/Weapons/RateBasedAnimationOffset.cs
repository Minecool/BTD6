namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "RateBasedAnimationOffset", menuName = "BTD6/Behaviors/Weapons/RateBasedAnimationOffset")]
public class RateBasedAnimationOffset : WeaponBehavior
{
	public float baseRate; //Field offset: 0x30
	public float offset; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public RateBasedAnimationOffset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

