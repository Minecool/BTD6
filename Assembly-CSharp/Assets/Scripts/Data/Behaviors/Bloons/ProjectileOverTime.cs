namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "ProjectileOverTime", menuName = "BTD6/Behaviors/Bloons/ProjectileOverTime")]
public class ProjectileOverTime : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public float interval; //Field offset: 0x40
	public PrefabReference display; //Field offset: 0x48
	public float displayLifespan; //Field offset: 0x50
	public bool triggerImmediate; //Field offset: 0x54
	public bool rotateEffectWithBloon; //Field offset: 0x55
	public float initialDelay; //Field offset: 0x58
	public bool emitOnDestroy; //Field offset: 0x5C
	public bool collideWithSelf; //Field offset: 0x5D

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 447
	}

	public ProjectileOverTime() { }

	public virtual BloonBehaviorModel get_Def() { }

}

