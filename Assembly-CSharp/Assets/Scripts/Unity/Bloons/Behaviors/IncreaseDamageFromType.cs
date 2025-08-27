namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class IncreaseDamageFromType : BloonBehavior
{
	public IncreaseDamageFromType parent; //Field offset: 0x88
	public string damageTypes; //Field offset: 0x90
	public string expDamageTypes; //Field offset: 0x98
	public float extraDamage; //Field offset: 0xA0
	public string expExtraDamage; //Field offset: 0xA8
	public bool useOriginalType; //Field offset: 0xB0
	public string expUseOriginalType; //Field offset: 0xB8

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 210
	}

	public IncreaseDamageFromType() { }

	public virtual BloonBehaviorModel get_Def() { }

}

