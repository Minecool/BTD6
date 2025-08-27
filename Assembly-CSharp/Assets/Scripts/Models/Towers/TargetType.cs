namespace Assets.Scripts.Models.Towers;

public struct TargetType : IEquatable<TargetType>
{
	public const string None = "None"; //Field offset: 0x0
	public const string PatrolPoints = "PatrolPoints"; //Field offset: 0x0
	public const string LockInPlace = "LockInPlace"; //Field offset: 0x0
	public const string FollowTouch = "FollowTouch"; //Field offset: 0x0
	public const string Pursuit = "Pursuit"; //Field offset: 0x0
	public const string Any = "Any"; //Field offset: 0x0
	public const string Random = "Random"; //Field offset: 0x0
	public static TargetType none; //Field offset: 0x0
	public const string Strong = "Strong"; //Field offset: 0x0
	public const string Far = "Far"; //Field offset: 0x0
	public const string Close = "Close"; //Field offset: 0x0
	public const string Last = "Last"; //Field offset: 0x0
	public const string First = "First"; //Field offset: 0x0
	public const string StrongExceptMoab = "StrongExceptMoab"; //Field offset: 0x0
	public static TargetType first; //Field offset: 0x18
	public static TargetType last; //Field offset: 0x30
	public static TargetType close; //Field offset: 0x48
	public static TargetType far; //Field offset: 0x60
	public static TargetType strong; //Field offset: 0x78
	public static TargetType strongExceptMoab; //Field offset: 0x90
	public static TargetType random; //Field offset: 0xA8
	public static TargetType any; //Field offset: 0xC0
	public string id; //Field offset: 0x0
	public bool isActionable; //Field offset: 0x8
	public bool actionOnCreate; //Field offset: 0x9
	public int intID; //Field offset: 0xC
	public bool continueToNextPriority; //Field offset: 0x10

	private static TargetType() { }

	public TargetType(string id, bool isActionable = false, bool actionOnCreate = false, bool continueToNextPriority = false) { }

	public static TargetType Decode(BinaryReader reader) { }

	public override bool Equals(TargetType other) { }

}

