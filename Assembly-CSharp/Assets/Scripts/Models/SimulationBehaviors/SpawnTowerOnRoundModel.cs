namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SpawnTowerOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnTowerOnRoundModel : SimulationBehaviorModel
{
	public string triggerId; //Field offset: 0x30
	public String[] prePlaceTowerIndexs; //Field offset: 0x38
	public Int32[] rounds; //Field offset: 0x40
	public bool AllAbilities; //Field offset: 0x48

	public SpawnTowerOnRoundModel(string triggerId, String[] prePlaceTowerIndexs, Int32[] rounds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

