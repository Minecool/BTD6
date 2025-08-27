namespace Assets.Scripts.Data.Behaviors.Simulations;

public struct EnableOptions : IEquatable<EnableOptions>
{
	public EnableMode Mode; //Field offset: 0x0
	public string TriggerId; //Field offset: 0x8
	public int EnableRound; //Field offset: 0x10

	public int EnableRoundIndex
	{
		[IsReadOnly]
		 get { } //Length: 6
	}

	public bool IsValid
	{
		[IsReadOnly]
		 get { } //Length: 56
	}

	public override bool Equals(EnableOptions other) { }

	[IsReadOnly]
	public int get_EnableRoundIndex() { }

	[IsReadOnly]
	public bool get_IsValid() { }

}

