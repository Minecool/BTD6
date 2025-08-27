namespace Assets.Scripts.Models.ServerEvents;

public class BloonModifiers : IEquatable<BloonModifiers>
{
	public float speedMultiplier; //Field offset: 0x10
	public float moabSpeedMultiplier; //Field offset: 0x14
	public float bossSpeedMultiplier; //Field offset: 0x18
	public float regrowRateMultiplier; //Field offset: 0x1C
	public BloonHealthMultipliers healthMultipliers; //Field offset: 0x20
	public bool allCamo; //Field offset: 0x28
	public bool allRegen; //Field offset: 0x29
	public bool allFortified; //Field offset: 0x2A

	public BloonModifiers() { }

	public override bool Equals(BloonModifiers other) { }

}

