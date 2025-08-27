namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(Hex), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HexModel : BloonBehaviorModelWithTowerTracking
{
	public float damagePercentOfMax; //Field offset: 0x38
	public int payloadCount; //Field offset: 0x3C
	[SerializeField]
	private float interval; //Field offset: 0x40
	public int intervalFrames; //Field offset: 0x44
	[SerializeField]
	private float totalDuration; //Field offset: 0x48
	public int totalIntervalFrames; //Field offset: 0x4C

	public HexModel() { }

	public HexModel(string name, float damagePercentOfMax, float interval, ObjectId tower, float totalDuration) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

