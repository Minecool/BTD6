namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CreateEffectProjectileAfterTime : ProjectileBehavior
{
	public CreateEffectProjectileAfterTime parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98
	public float time; //Field offset: 0xA0
	public string expTime; //Field offset: 0xA8
	public bool repeat; //Field offset: 0xB0
	public string expRepeat; //Field offset: 0xB8
	public bool isBuffedByRate; //Field offset: 0xC0
	public string expIsBuffedByRate; //Field offset: 0xC8
	public bool useTargetPosition; //Field offset: 0xD0
	public string expUseTargetPosition; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 279
	}

	public CreateEffectProjectileAfterTime() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

