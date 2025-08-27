namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivatePierceSupportZone", menuName = "BTD6/Behaviors/Abilities/ActivatePierceSupportZone")]
public class ActivatePierceSupportZone : AbilityBehavior
{
	public string mutatorId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x3C
	public int pierceIncrease; //Field offset: 0x40
	public float range; //Field offset: 0x44
	public int maxNumTowersModified; //Field offset: 0x48
	public bool affectThisTower; //Field offset: 0x4C
	public bool useTowerRange; //Field offset: 0x4D
	public string buffLocsName; //Field offset: 0x50
	public string buffIconName; //Field offset: 0x58
	public TowerFilter[] filters; //Field offset: 0x60

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 318
	}

	public ActivatePierceSupportZone() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

