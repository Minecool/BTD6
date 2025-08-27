namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AddBonusDamagePerHitToBloon", menuName = "BTD6/Behaviors/Projectiles/AddBonusDamagePerHitToBloon")]
public class AddBonusDamagePerHitToBloon : ProjectileBehavior
{
	public string mutationId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public float perHitDamageAddition; //Field offset: 0x3C
	public int layers; //Field offset: 0x40
	public bool isUnique; //Field offset: 0x44
	public bool lastAppliesFirst; //Field offset: 0x45
	public bool cascadeMutators; //Field offset: 0x46
	public string overlayType; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 228
	}

	public AddBonusDamagePerHitToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

