namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "PsiEffect", menuName = "BTD6/Behaviors/Projectiles/PsiEffect")]
public class PsiEffect : ProjectileBehavior
{
	public string overlayType; //Field offset: 0x30
	public int damagePerTick; //Field offset: 0x38
	public float tickRate; //Field offset: 0x3C
	public float trembleDistanceMin; //Field offset: 0x40
	public float trembleDistanceMax; //Field offset: 0x44
	public float trembleTimeThresholdMin; //Field offset: 0x48
	public float trembleTimeThresholdMax; //Field offset: 0x4C
	public float trembleSpeed; //Field offset: 0x50
	public Projectile projectileOnBloonDestroy; //Field offset: 0x58
	public Effect effectOnBloonDestroy; //Field offset: 0x60
	public int superCeramicPenalty; //Field offset: 0x68
	public float maxDuration; //Field offset: 0x6C
	public Emission emissionOnBloonDestroy; //Field offset: 0x70

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 441
	}

	public PsiEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

