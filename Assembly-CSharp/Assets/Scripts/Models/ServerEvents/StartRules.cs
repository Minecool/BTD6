namespace Assets.Scripts.Models.ServerEvents;

public class StartRules : IEquatable<StartRules>
{
	public int lives; //Field offset: 0x10
	public int maxLives; //Field offset: 0x14
	public int cash; //Field offset: 0x18
	public int round; //Field offset: 0x1C
	public int endRound; //Field offset: 0x20
	public int revives; //Field offset: 0x24

	public StartRules() { }

	public override bool Equals(StartRules other) { }

}

