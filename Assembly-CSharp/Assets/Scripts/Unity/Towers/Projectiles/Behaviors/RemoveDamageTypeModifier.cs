namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RemoveDamageTypeModifier : ProjectileBehavior
{
	public RemoveDamageTypeModifier parent; //Field offset: 0x88
	[TextArea(2, 5)]
	[Tooltip("Damage Type: Can pass 1 type or multiple via comer separation e.g. 'Sharp, Shatter, Explosion'")]
	public string type; //Field offset: 0x90
	public string expType; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public int layers; //Field offset: 0xB0
	public string expLayers; //Field offset: 0xB8
	public string mutationId; //Field offset: 0xC0
	public string expMutationId; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 228
	}

	public RemoveDamageTypeModifier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

