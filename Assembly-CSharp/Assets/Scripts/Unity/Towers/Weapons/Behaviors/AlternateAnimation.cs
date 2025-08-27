namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class AlternateAnimation : WeaponBehavior
{
	public AlternateAnimation parent; //Field offset: 0x90
	public int states; //Field offset: 0x98
	public string expStates; //Field offset: 0xA0
	public int originState; //Field offset: 0xA8
	public string expOriginState; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 132
	}

	public AlternateAnimation() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

