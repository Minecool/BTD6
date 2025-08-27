namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TravelStraitSlowdown), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TravelStraitSlowdownModel : TravelStraitModel
{
	[SerializeField]
	private float slowdownSpeed; //Field offset: 0x48
	public float slowdownSpeedFrames; //Field offset: 0x4C
	[SerializeField]
	private float minSpeed; //Field offset: 0x50
	public float minSpeedFrames; //Field offset: 0x54
	public float maxDistance; //Field offset: 0x58
	public bool canReducePierce; //Field offset: 0x5C
	public int startingPierce; //Field offset: 0x60
	public int endPierce; //Field offset: 0x64

	public TravelStraitSlowdownModel(string name, float speed = 4, float lifespan = 1, float slowdownSpeed = 0, float minSpeed = 0, bool canReducePierce = false, int startingPierce = -1, int endPierce = -1) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

