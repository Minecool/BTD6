namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class PauseOtherAttacks : WeaponBehavior
{
	public PauseOtherAttacks parent; //Field offset: 0x90
	public float duration; //Field offset: 0x98
	public string expDuration; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public PauseOtherAttacks() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

