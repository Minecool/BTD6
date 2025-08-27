namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class DamageOverTimeForTag : BloonBehavior
{
	public int damage; //Field offset: 0x88
	public string expDamage; //Field offset: 0x90
	public float interval; //Field offset: 0x98
	public string expInterval; //Field offset: 0xA0
	public string damageType; //Field offset: 0xA8
	public string expDamageType; //Field offset: 0xB0
	public string bloonTag; //Field offset: 0xB8
	public string expBloonTag; //Field offset: 0xC0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 352
	}

	public DamageOverTimeForTag() { }

	public virtual BloonBehaviorModel get_Def() { }

}

