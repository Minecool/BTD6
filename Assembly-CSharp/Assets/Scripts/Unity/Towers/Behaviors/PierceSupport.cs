namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PierceSupport : SupportBehavior
{
	public PierceSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float pierce; //Field offset: 0xE0
	public string expPierce; //Field offset: 0xE8
	public string mutatorId; //Field offset: 0xF0
	public string expMutatorId; //Field offset: 0xF8
	public bool isGlobal; //Field offset: 0x100
	public string expIsGlobal; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 273
	}

	public PierceSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

