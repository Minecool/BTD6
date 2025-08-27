namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AcidPool), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AcidPoolModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float lifespan; //Field offset: 0x38
	public int lifespanFrames; //Field offset: 0x3C
	[SerializeField]
	private float lifespanIfMisses; //Field offset: 0x40
	public int lifespanFramesIfMisses; //Field offset: 0x44
	public float radiusIfMisses; //Field offset: 0x48
	public float pierce; //Field offset: 0x4C

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public float LifespanIfMisses
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public AcidPoolModel(string name, float lifespan, float lifespanIfMisses, float radiusIfMisses, float pierce) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public float get_LifespanIfMisses() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

	public void set_LifespanIfMisses(float value) { }

}

