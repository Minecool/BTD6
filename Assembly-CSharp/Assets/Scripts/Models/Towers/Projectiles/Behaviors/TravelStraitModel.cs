namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TravelStrait), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TravelStraitModel : ProjectileBehaviorModel
{
	[SerializeField]
	protected float speed; //Field offset: 0x38
	public float speedFrames; //Field offset: 0x3C
	[SerializeField]
	protected float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 29
	}

	public float Speed
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public TravelStraitModel(string name, float speed = 4, float lifespan = 1) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public float get_Speed() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

	public void set_Speed(float value) { }

}

