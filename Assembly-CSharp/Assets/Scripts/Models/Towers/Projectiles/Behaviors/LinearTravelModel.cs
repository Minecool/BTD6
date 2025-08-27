namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(LinearTravel), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LinearTravelModel : ProjectileBehaviorModel
{
	public bool dontDestroyOnTargetLoss; //Field offset: 0x38
	public bool forceCollisionOnSnap; //Field offset: 0x39
	[SerializeField]
	private float speed; //Field offset: 0x3C
	public float speedFrames; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x44
	public int lifespanFrames; //Field offset: 0x48

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

	public LinearTravelModel(string name, float speed, float lifespan, bool dontDestroyOnTargetLoss, bool forceCollisionOnSnap) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public float get_Speed() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

	public void set_Speed(float value) { }

}

