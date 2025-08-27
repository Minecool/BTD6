namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DamageOverTimeZone : TowerBehavior
{
	public DamageOverTimeZone parent; //Field offset: 0x98
	public DamageOverTime behavior; //Field offset: 0xA0
	public float range; //Field offset: 0xA8
	public string expRange; //Field offset: 0xB0
	public bool isGlobal; //Field offset: 0xB8
	public string expIsGlobal; //Field offset: 0xC0
	public bool filterInvisible; //Field offset: 0xC8
	public string expFilterInvisible; //Field offset: 0xD0
	public bool onlyAffectOnscreen; //Field offset: 0xD8
	public string expOnlyAffectOnscreen; //Field offset: 0xE0
	public string mutatorId; //Field offset: 0xE8
	public string expMutatorId; //Field offset: 0xF0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 361
	}

	public DamageOverTimeZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

