namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(BonusLivesPerRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
internal class BonusLivesPerRoundModel : SimulationBehaviorModel
{
	public float livesRestored; //Field offset: 0x30
	public float maxLivesAboveStartingLives; //Field offset: 0x34

	public BonusLivesPerRoundModel(string name, float livesRestored, float maxLivesAboveStartingLives) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

