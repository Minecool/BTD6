namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateRateSupportZone", menuName = "BTD6/Behaviors/Abilities/ActivateRateSupportZone")]
public class ActivateRateSupportZone : AbilityBehavior
{
	public string mutatorId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x3C
	public float rateModifier; //Field offset: 0x40
	public float range; //Field offset: 0x44
	public int maxNumTowersModified; //Field offset: 0x48
	public bool affectThisTower; //Field offset: 0x4C
	public bool useTowerRange; //Field offset: 0x4D
	public Display addEffectToTowersAffected; //Field offset: 0x50
	public string buffLocsName; //Field offset: 0x58
	public string buffIconName; //Field offset: 0x60
	public TowerFilter[] towerFilters; //Field offset: 0x68

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 433
	}

	public ActivateRateSupportZone() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

