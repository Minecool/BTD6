namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class RateBasedAnimationOffset : WeaponBehavior
{
	public RateBasedAnimationOffset parent; //Field offset: 0x90
	public float baseRate; //Field offset: 0x98
	public string expBaseRate; //Field offset: 0xA0
	public float offset; //Field offset: 0xA8
	public string expOffset; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public RateBasedAnimationOffset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

