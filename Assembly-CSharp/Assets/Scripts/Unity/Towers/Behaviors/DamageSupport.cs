namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DamageSupport : SupportBehavior
{
	public DamageSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float increase; //Field offset: 0xE0
	public string expIncrease; //Field offset: 0xE8
	public string mutatorId; //Field offset: 0xF0
	public string expMutatorId; //Field offset: 0xF8
	public bool isGlobal; //Field offset: 0x100
	public string expIsGlobal; //Field offset: 0x108
	public bool isCustomRadius; //Field offset: 0x110
	public string expIsCustomRadius; //Field offset: 0x118
	public float customRadius; //Field offset: 0x120
	public string expCustomRadius; //Field offset: 0x128

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 287
	}

	public DamageSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

