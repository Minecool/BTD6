namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SupportRemoveFilterOutTag", menuName = "BTD6/Behaviors/Towers/SupportRemoveFilterOutTag")]
public class SupportRemoveFilterOutTag : SupportBehavior
{
	public string removeScriptWithSupportMutatorId; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x58
	public bool isCustomRadius; //Field offset: 0x59
	public float customRadius; //Field offset: 0x5C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 310
	}

	public SupportRemoveFilterOutTag() { }

	public virtual TowerBehaviorModel get_Def() { }

}

