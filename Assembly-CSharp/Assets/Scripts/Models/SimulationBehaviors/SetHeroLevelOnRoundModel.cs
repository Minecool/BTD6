namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SetHeroLevelOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetHeroLevelOnRoundModel : SimulationBehaviorModel
{
	[TowerType]
	public string tower; //Field offset: 0x30
	public Int32[] roundArr; //Field offset: 0x38
	public Int32[] levelArr; //Field offset: 0x40

	public SetHeroLevelOnRoundModel(Int32[] roundArr, string tower, Int32[] levelArr) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

