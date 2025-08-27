namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DamageSupport", menuName = "BTD6/Behaviors/Towers/DamageSupport")]
public class DamageSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float increase; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x58
	public bool isCustomRadius; //Field offset: 0x59
	public float customRadius; //Field offset: 0x5C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 303
	}

	public DamageSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

