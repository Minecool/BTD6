namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamagePercentOfMax : ProjectileBehavior
{
	public DamagePercentOfMax parent; //Field offset: 0x88
	public float percent; //Field offset: 0x90
	public string expPercent; //Field offset: 0x98
	[FormerlySerializedAs("tag")]
	public string tagValue; //Field offset: 0xA0
	[FormerlySerializedAs("expTag")]
	public string expTagValue; //Field offset: 0xA8
	public bool damageBloonsOffscreenOnly; //Field offset: 0xB0
	public string expDamageBloonsOffscreenOnly; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 210
	}

	public DamagePercentOfMax() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

