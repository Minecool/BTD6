namespace Assets.Scripts.Models.Map;

[Implementation(typeof(TrackArrow), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrackArrowModel : Model
{
	public DisplayModel displayModel; //Field offset: 0x30
	[SerializeField]
	private float speed; //Field offset: 0x38
	public int speedFrames; //Field offset: 0x3C
	public float firstCoveragePercent; //Field offset: 0x40
	public float secondCoveragePercent; //Field offset: 0x44
	public float distanceToTravel; //Field offset: 0x48
	public float enterAndExitBuffer; //Field offset: 0x4C
	[SerializeField]
	private float rate; //Field offset: 0x50
	public int rateFrames; //Field offset: 0x54
	[SerializeField]
	private float subRate; //Field offset: 0x58
	public int subRateFrames; //Field offset: 0x5C
	public int numOfArrows; //Field offset: 0x60
	public ColorModel firstColorStart; //Field offset: 0x68
	public ColorModel firstColorEnd; //Field offset: 0x70
	public ColorModel secondColorStart; //Field offset: 0x78
	public ColorModel secondColorEnd; //Field offset: 0x80

	public TrackArrowModel(DisplayModel displayModel, float speed, float firstCoveragePercent, float secondCoveragePercent, float enterAndExitBuffer, float rate, float subRate, int numOfArrows, ColorModel firstColorStart, ColorModel firstColorEnd, ColorModel secondColorStart, ColorModel secondColorEnd, float distanceToTravel = 120) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

