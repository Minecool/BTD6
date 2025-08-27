namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AgeRandom), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AgeRandomModel : AgeModel
{
	[SerializeField]
	private float minLifespan; //Field offset: 0x50
	public int minLifespanFrames; //Field offset: 0x54
	[SerializeField]
	private float maxLifespan; //Field offset: 0x58
	public int maxLifespanFrames; //Field offset: 0x5C

	public AgeRandomModel(string name, float minLifespan, float maxLifespan, int rounds, bool useRoundTime, EndOfRoundClearBypassModel endOfRoundClearBypassModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

