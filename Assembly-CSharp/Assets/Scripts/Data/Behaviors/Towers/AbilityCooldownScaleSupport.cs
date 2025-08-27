namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AbilityCooldownScaleSupport", menuName = "BTD6/Behaviors/Towers/AbilityCooldownScaleSupport")]
public class AbilityCooldownScaleSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float abilityCooldownSpeedScale; //Field offset: 0x4C
	public bool affectsOnlyWater; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x51
	public bool onlyShowBuffIconIfMutated; //Field offset: 0x52

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 254
	}

	public AbilityCooldownScaleSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

