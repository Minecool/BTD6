namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EjectAnimation : WeaponBehavior
{
	public EjectAnimation parent; //Field offset: 0x90
	public int animationState; //Field offset: 0x98
	public string expAnimationState; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public EjectAnimation() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

