namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class PsiEffect : ProjectileBehavior
{
	public PsiEffect parent; //Field offset: 0x88
	public string overlayType; //Field offset: 0x90
	public string expOverlayType; //Field offset: 0x98
	public int damagePerTick; //Field offset: 0xA0
	public string expDamagePerTick; //Field offset: 0xA8
	public float tickRate; //Field offset: 0xB0
	public string expTickRate; //Field offset: 0xB8
	public float trembleDistanceMin; //Field offset: 0xC0
	public string expTrembleDistanceMin; //Field offset: 0xC8
	public float trembleDistanceMax; //Field offset: 0xD0
	public string expTrembleDistanceMax; //Field offset: 0xD8
	public float trembleTimeThresholdMin; //Field offset: 0xE0
	public string expTrembleTimeThresholdMin; //Field offset: 0xE8
	public float trembleTimeThresholdMax; //Field offset: 0xF0
	public string expTrembleTimeThresholdMax; //Field offset: 0xF8
	public float trembleSpeed; //Field offset: 0x100
	public string expTrembleSpeed; //Field offset: 0x108
	public Projectile projectileOnBloonDestroy; //Field offset: 0x110
	public Effect effectOnBloonDestroy; //Field offset: 0x118
	public Effect expEffectOnBloonDestroy; //Field offset: 0x120
	public int superCeramicPenalty; //Field offset: 0x128
	public string expSuperCeramicPenalty; //Field offset: 0x130
	public float maxDuration; //Field offset: 0x138
	public string expMaxDuration; //Field offset: 0x140
	public Emission emissionOnBloonDestroy; //Field offset: 0x148

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 456
	}

	public PsiEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

