namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DamageModifierSupport", menuName = "BTD6/Behaviors/Towers/DamageModifierSupport")]
public class DamageModifierSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x58
	public DamageModifier damageModifier; //Field offset: 0x60

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 344
	}

	public DamageModifierSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

