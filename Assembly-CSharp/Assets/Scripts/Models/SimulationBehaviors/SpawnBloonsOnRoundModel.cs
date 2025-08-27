namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SpawnBloonsOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnBloonsOnRoundModel : SimulationBehaviorModel
{
	[BloonType]
	public string bloonId; //Field offset: 0x30
	public int count; //Field offset: 0x38
	public Single[] distanceAlongTrack; //Field offset: 0x40
	public int round; //Field offset: 0x48

	public SpawnBloonsOnRoundModel(string bloonId, int count, Single[] distanceAlongTrack, int round) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

