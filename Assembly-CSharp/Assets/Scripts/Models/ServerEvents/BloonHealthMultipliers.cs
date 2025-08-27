namespace Assets.Scripts.Models.ServerEvents;

public class BloonHealthMultipliers : IEquatable<BloonHealthMultipliers>
{
	public float bloons; //Field offset: 0x10
	public float moabs; //Field offset: 0x14
	public float boss; //Field offset: 0x18

	public BloonHealthMultipliers() { }

	public override bool Equals(BloonHealthMultipliers other) { }

}

