namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateEffectOnExhausted : ProjectileBehavior
{
	public CreateEffectOnExhausted parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public Fullscreen fullscreen; //Field offset: 0xB0
	public string expFullscreen; //Field offset: 0xB8
	public bool randomRotation; //Field offset: 0xC0
	public string expRandomRotation; //Field offset: 0xC8
	public GameObject display; //Field offset: 0xD0
	public GameObject expDisplay; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 944
	}

	public CreateEffectOnExhausted() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

