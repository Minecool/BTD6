namespace Assets.Scripts.Models.ServerEvents;

public class CashModifiers : IEquatable<CashModifiers>
{
	public float popCashMultiplier; //Field offset: 0x10
	public float towerCashMultiplier; //Field offset: 0x14
	public float roundCashMultiplier; //Field offset: 0x18

	public CashModifiers() { }

	public override bool Equals(CashModifiers other) { }

}

