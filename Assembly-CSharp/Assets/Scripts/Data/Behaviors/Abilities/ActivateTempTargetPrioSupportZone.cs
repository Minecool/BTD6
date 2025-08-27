namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateTempTargetPrioSupportZone", menuName = "BTD6/Behaviors/Abilities/ActivateTempTargetPrioSupportZone")]
public class ActivateTempTargetPrioSupportZone : AbilityBehavior
{
	public string mutatorId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x3C
	public float range; //Field offset: 0x40
	public int maxNumTowersModified; //Field offset: 0x44
	public bool affectThisTower; //Field offset: 0x48
	public bool useTowerRange; //Field offset: 0x49
	public Display addEffectToTowersAffected; //Field offset: 0x50
	public string buffLocsName; //Field offset: 0x58
	public string buffIconName; //Field offset: 0x60
	public TargetTypeBehavior targetType; //Field offset: 0x68
	public float accuracyImprovementPercent; //Field offset: 0x70
	public TowerFilter[] towerFilters; //Field offset: 0x78

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 548
	}

	public ActivateTempTargetPrioSupportZone() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

