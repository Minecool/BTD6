namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class IgnoreDmgImmunity : BloonBehavior
{
	public IgnoreDmgImmunity parent; //Field offset: 0x88
	public string damageType; //Field offset: 0x90
	public string expDamageType; //Field offset: 0x98
	public float chance; //Field offset: 0xA0
	public string expChance; //Field offset: 0xA8

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 183
	}

	public IgnoreDmgImmunity() { }

	public virtual BloonBehaviorModel get_Def() { }

}

