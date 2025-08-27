namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddBonusDamagePerHitToBloon : ProjectileBehavior
{
	public AddBonusDamagePerHitToBloon parent; //Field offset: 0x88
	public string mutationId; //Field offset: 0x90
	public string expMutationId; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public float perHitDamageAddition; //Field offset: 0xB0
	public string expPerHitDamageAddition; //Field offset: 0xB8
	public int layers; //Field offset: 0xC0
	public string expLayers; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public bool lastAppliesFirst; //Field offset: 0xE0
	public string expLastAppliesFirst; //Field offset: 0xE8
	public bool cascadeMutators; //Field offset: 0xF0
	public string expCascadeMutators; //Field offset: 0xF8
	public string overlayType; //Field offset: 0x100
	public string expOverlayType; //Field offset: 0x108

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 252
	}

	public AddBonusDamagePerHitToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

