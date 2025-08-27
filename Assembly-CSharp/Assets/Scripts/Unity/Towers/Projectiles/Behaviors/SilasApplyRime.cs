namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SilasApplyRime : ProjectileBehavior
{
	public SilasApplyRime parent; //Field offset: 0x88
	[Header("Rime Variables")]
	public string mutationId; //Field offset: 0x90
	public string expMutationId; //Field offset: 0x98
	public float speedModifier; //Field offset: 0xA0
	public string expspeedModifier; //Field offset: 0xA8
	public float moabSpeedModifier; //Field offset: 0xB0
	public string expMoabSpeedModifier; //Field offset: 0xB8
	public string overlayType; //Field offset: 0xC0
	public string expOverlayType; //Field offset: 0xC8
	public bool canAttackWhiteBloons; //Field offset: 0xD0
	public string expCanAttackWhiteBloons; //Field offset: 0xD8
	public int mutationPrio; //Field offset: 0xE0
	public string expMutationPrio; //Field offset: 0xE8
	public BloonBehavior behavior; //Field offset: 0xF0
	public BloonBehavior expBehavior; //Field offset: 0xF8
	[Header("Freeze Variables")]
	public float freezeSpeed; //Field offset: 0x100
	public string expFreezeSpeed; //Field offset: 0x108
	public int freezeLayers; //Field offset: 0x110
	public string expFreezeLayers; //Field offset: 0x118
	public string freezeMutationId; //Field offset: 0x120
	public string expFreezeMutationId; //Field offset: 0x128
	public float freezePercentChanceToFreeze; //Field offset: 0x130
	public string expFreezePercentChanceToFreeze; //Field offset: 0x138
	public bool freezeEnablePercentChanceToFreeze; //Field offset: 0x140
	public string expFreezeEnablePercentChanceToFreeze; //Field offset: 0x148
	public float freezeLifespan; //Field offset: 0x150
	public string expFreezeLifespan; //Field offset: 0x158
	public string freezeOverlayType; //Field offset: 0x160
	public string expFreezeOverlayType; //Field offset: 0x168
	public bool freezeCascadeMutators; //Field offset: 0x170
	public string expFreezeCascadeMutators; //Field offset: 0x178
	public bool freezeCanFreezeMoabs; //Field offset: 0x180
	public string expFreezeCanFreezeMoabs; //Field offset: 0x188
	public bool freezeApplyAfterDamage; //Field offset: 0x190
	public string expFreezeApplyAfterDamage; //Field offset: 0x198
	[Header("Explosion Variables")]
	public Projectile projectile; //Field offset: 0x1A0
	public Emission emission; //Field offset: 0x1A8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1113
	}

	public SilasApplyRime() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

