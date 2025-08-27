namespace Assets.Scripts.Models.ContentBrowser;

public class PathNode : ISplineNode, ICloneable<PathNode>
{
	[JsonConverter(typeof(Vector3ConverterSmall))]
	public Vector3 position; //Field offset: 0x10
	[JsonConverter(typeof(Vector3ConverterSmall))]
	public Vector3 leftTangent; //Field offset: 0x1C
	[JsonConverter(typeof(Vector3ConverterSmall))]
	public Vector3 rightTangent; //Field offset: 0x28
	public bool isExitNode; //Field offset: 0x34
	public int invulnerableMoabsNodeState; //Field offset: 0x38
	public int invulnerableBloonsNodeState; //Field offset: 0x3C
	public int scaleMoabsNodeState; //Field offset: 0x40
	public int scaleBloonsNodeState; //Field offset: 0x44
	public int scaleBloonSpeedNodeState; //Field offset: 0x48
	public bool invulMoabs; //Field offset: 0x4C
	public bool invulBloons; //Field offset: 0x4D
	public float scaleMoabsState; //Field offset: 0x50
	public float scaleBloonsState; //Field offset: 0x54
	public float speedScaleState; //Field offset: 0x58

	[JsonIgnore]
	public override Vector3 LeftTangentPosition
	{
		 get { } //Length: 57
	}

	[JsonIgnore]
	public override Vector3 Position
	{
		 get { } //Length: 33
	}

	[JsonIgnore]
	public override Vector3 RightTangentPosition
	{
		 get { } //Length: 57
	}

	public PathNode() { }

	public override PathNode Clone() { }

	public bool Equals(PathNode com) { }

	public override Vector3 get_LeftTangentPosition() { }

	public override Vector3 get_Position() { }

	public override Vector3 get_RightTangentPosition() { }

}

