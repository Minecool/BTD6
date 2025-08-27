namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class ProjectileOverTime : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x88
	public Emission emission; //Field offset: 0x90
	public float interval; //Field offset: 0x98
	public string expInterval; //Field offset: 0xA0
	public GameObject display; //Field offset: 0xA8
	public GameObject expDisplay; //Field offset: 0xB0
	public float displayLifespan; //Field offset: 0xB8
	public string expDisplayLifespan; //Field offset: 0xC0
	public bool triggerImmediate; //Field offset: 0xC8
	public string expTriggerImmediate; //Field offset: 0xD0
	public bool rotateEffectWithBloon; //Field offset: 0xD8
	public string expRotateEffectWithBloon; //Field offset: 0xE0
	public float initialDelay; //Field offset: 0xE8
	public string expInitialDelay; //Field offset: 0xF0
	public bool emitOnDestroy; //Field offset: 0xF8
	public string expEmitOnDestroy; //Field offset: 0x100
	public bool collideWithSelf; //Field offset: 0x108
	public string expCollideWithSelf; //Field offset: 0x110

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 738
	}

	public ProjectileOverTime() { }

	public virtual BloonBehaviorModel get_Def() { }

}

