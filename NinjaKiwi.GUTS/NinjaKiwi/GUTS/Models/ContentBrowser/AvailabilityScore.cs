namespace NinjaKiwi.GUTS.Models.ContentBrowser;

[JsonConverter(typeof(AvailabilityScoreConverter))]
public struct AvailabilityScore : IComparable<AvailabilityScore>
{
	public static readonly AvailabilityScoreComponent[] AllScoreComponents; //Field offset: 0x0
	public const byte kMaxBitOffset = 31; //Field offset: 0x0
	public const AvailabilityScoreComponent kComponentMask = 15; //Field offset: 0x0
	private int rawScore; //Field offset: 0x0

	public static AvailabilityScore Zero
	{
		 get { } //Length: 36
	}

	private static AvailabilityScore() { }

	[JsonConstructor]
	public AvailabilityScore(int rawAvailabilityScore) { }

	public AvailabilityScore(IEnumerable<ValueTuple`2<AvailabilityScoreComponent, Int32>> componentValues) { }

	[IsReadOnly]
	public override int CompareTo(AvailabilityScore other) { }

	[IsReadOnly]
	public bool Equals(AvailabilityScore other) { }

	[IsReadOnly]
	public virtual bool Equals(object obj) { }

	public static AvailabilityScore get_Zero() { }

	[IsReadOnly]
	public virtual int GetHashCode() { }

	[IsReadOnly]
	public int GetScore(AvailabilityScoreComponent scoreComponent) { }

	public static bool op_Equality(AvailabilityScore l, AvailabilityScore r) { }

	public static bool op_GreaterThan(AvailabilityScore l, AvailabilityScore r) { }

	public static int op_Implicit(AvailabilityScore d) { }

	public static bool op_Inequality(AvailabilityScore l, AvailabilityScore r) { }

	public static bool op_LessThan(AvailabilityScore l, AvailabilityScore r) { }

	public void SetScore(AvailabilityScoreComponent scoreComponent, int score) { }

	private static void ThrowIfIncompatible(AvailabilityScoreComponent componentMask) { }

	[IsReadOnly]
	public virtual string ToString() { }

}

