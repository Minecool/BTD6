namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateEffectOnExpire : ProjectileBehavior
{
	public CreateEffectOnExpire parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public PrefabReference prefabDisplay; //Field offset: 0xB0
	public PrefabReference expPrefabDisplay; //Field offset: 0xB8
	public Fullscreen fullscreen; //Field offset: 0xC0
	public string expFullscreen; //Field offset: 0xC8
	public bool randomRotation; //Field offset: 0xD0
	public string expRandomRotation; //Field offset: 0xD8
	public Effect effect; //Field offset: 0xE0
	public Effect expEffect; //Field offset: 0xE8
	public bool useTargetPosition; //Field offset: 0xF0
	public string expUseTargetPosition; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 891
	}

	public CreateEffectOnExpire() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

