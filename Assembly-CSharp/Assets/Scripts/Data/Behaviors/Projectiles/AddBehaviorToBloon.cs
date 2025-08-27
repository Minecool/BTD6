namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AddBehaviorToBloon", menuName = "BTD6/Behaviors/Projectiles/AddBehaviorToBloon")]
public class AddBehaviorToBloon : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public int layers; //Field offset: 0x34
	public GlueLevel mutationId; //Field offset: 0x38
	public BloonBehavior behavior; //Field offset: 0x40
	public string overlayType; //Field offset: 0x48
	public Filter bloonFilter; //Field offset: 0x50
	public Filter[] bloonFilters; //Field offset: 0x58
	public bool isUnique; //Field offset: 0x60
	public bool lastAppliesFirst; //Field offset: 0x61
	public bool processThisFrame; //Field offset: 0x62
	public bool cascadeMutators; //Field offset: 0x63
	public bool applyOnlyIfDamaged; //Field offset: 0x64
	public int stackCount; //Field offset: 0x68
	public bool dontCopy; //Field offset: 0x6C
	public Damage parentDamageBehaviour; //Field offset: 0x70

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1068
	}

	public AddBehaviorToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

