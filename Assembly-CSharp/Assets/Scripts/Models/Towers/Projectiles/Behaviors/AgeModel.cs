namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Age), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AgeModel : ProjectileBehaviorModel
{
	public int rounds; //Field offset: 0x38
	public bool useRoundTime; //Field offset: 0x3C
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44
	public EndOfRoundClearBypassModel endOfRoundClearBypassModel; //Field offset: 0x48

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 109
	}

	public AgeModel(string name, float lifespan, int rounds, bool useRoundTime, EndOfRoundClearBypassModel endOfRoundClearBypassModel) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

