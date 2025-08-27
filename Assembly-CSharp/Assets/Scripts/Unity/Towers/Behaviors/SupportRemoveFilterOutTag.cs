namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SupportRemoveFilterOutTag : SupportBehavior
{
	public SupportRemoveFilterOutTag parent; //Field offset: 0xC8
	public string removeScriptWithSupportMutatorId; //Field offset: 0xD0
	public string expRemoveScriptWithSupportMutatorId; //Field offset: 0xD8
	public string mutatorId; //Field offset: 0xE0
	public string expMutatorId; //Field offset: 0xE8
	public bool isGlobal; //Field offset: 0xF0
	public string expIsGlobal; //Field offset: 0xF8
	public bool isCustomRadius; //Field offset: 0x100
	public string expIsCustomRadius; //Field offset: 0x108
	public float customRadius; //Field offset: 0x110
	public string expCustomRadius; //Field offset: 0x118

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 357
	}

	public SupportRemoveFilterOutTag() { }

	public virtual TowerBehaviorModel get_Def() { }

}

