namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(HeroXpPerRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeroXpPerRoundModel : TowerBehaviorModel
{
	public float additionalXpPerRound; //Field offset: 0x30

	public HeroXpPerRoundModel(string name, float additionalXpPerRound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

