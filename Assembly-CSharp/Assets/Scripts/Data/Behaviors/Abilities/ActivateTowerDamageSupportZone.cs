namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateTowerDamageSupportZone", menuName = "BTD6/Behaviors/Abilities/ActivateTowerDamageSupportZone")]
public class ActivateTowerDamageSupportZone : AbilityBehavior
{
	public string mutatorId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x3C
	public float damageIncrease; //Field offset: 0x40
	public float range; //Field offset: 0x44
	public float maxNumTowersModified; //Field offset: 0x48
	public bool canEffectThisTower; //Field offset: 0x4C
	public Display addEffectToTowersAffected; //Field offset: 0x50
	public string buffLocsName; //Field offset: 0x58
	public string buffIconName; //Field offset: 0x60
	public string damageTypeToSet; //Field offset: 0x68
	public bool useTowerRange; //Field offset: 0x70
	public TowerFilter[] filters; //Field offset: 0x78

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 536
	}

	public ActivateTowerDamageSupportZone() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

