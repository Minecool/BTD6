namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DelayBloonChildrenSpawning), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DelayBloonChildrenSpawningModel : ProjectileBehaviorModel
{
	public bool createWindEffectOnChildBloons; //Field offset: 0x38
	public Vector3 ejectLocation; //Field offset: 0x3C
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public DelayBloonChildrenSpawningModel(string id, float delaySpawnDuration, bool createWindEffectOnChildBloons) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

