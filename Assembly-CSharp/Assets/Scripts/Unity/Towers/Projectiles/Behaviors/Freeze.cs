namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Freeze : ProjectileBehavior
{
	public Freeze parent; //Field offset: 0x88
	public float speed; //Field offset: 0x90
	public string expSpeed; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public int layers; //Field offset: 0xB0
	public string expLayers; //Field offset: 0xB8
	public string mutationId; //Field offset: 0xC0
	public string expMutationId; //Field offset: 0xC8
	public string overlayType; //Field offset: 0xD0
	public string expOverlayType; //Field offset: 0xD8
	public bool cascadeMutators; //Field offset: 0xE0
	public string expCascadeMutators; //Field offset: 0xE8
	public float percentChanceToFreeze; //Field offset: 0xF0
	public string expPercentChanceToFreeze; //Field offset: 0xF8
	public bool enablePercentChanceToFreeze; //Field offset: 0x100
	public string expEnablePercentChanceToFreeze; //Field offset: 0x108
	public bool canFreezeMoabs; //Field offset: 0x110
	public string expCanFreezeMoabs; //Field offset: 0x118
	public bool applyAfterDamage; //Field offset: 0x120
	public string expApplyAfterDamage; //Field offset: 0x128

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 648
	}

	public Freeze() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

