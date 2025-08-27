namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SilasTrackTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SilasTrackTargetModel : ProjectileBehaviorModel
{
	public float rotation; //Field offset: 0x38
	public float minimumSpeed; //Field offset: 0x3C
	public float minimumSpeedFrames; //Field offset: 0x40
	public float maximumSpeed; //Field offset: 0x44
	public float maximumSpeedFrames; //Field offset: 0x48
	public float acceleration; //Field offset: 0x4C
	public float accelerationFrames; //Field offset: 0x50
	[SerializeField]
	private float lifespan; //Field offset: 0x54
	public int lifespanFrames; //Field offset: 0x58
	public bool isUsingSharedRange; //Field offset: 0x5C
	public Single[] spawnMarker; //Field offset: 0x60
	public SoundModel[] sounds; //Field offset: 0x68
	public float projectileWaitTime; //Field offset: 0x70

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 29
	}

	public SilasTrackTargetModel(string name, float rotation, float minimumSpeed, float maximumSpeed, float acceleration, float lifespan, Single[] spawnMaker, bool usingSharedRange, SoundModel[] sounds, float projectileWaitTime = 1) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

