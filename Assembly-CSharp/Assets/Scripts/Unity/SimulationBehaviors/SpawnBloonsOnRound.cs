namespace Assets.Scripts.Unity.SimulationBehaviors;

public class SpawnBloonsOnRound : SimulationBehavior
{
	[BloonType]
	public string bloonId; //Field offset: 0x18
	public int count; //Field offset: 0x20
	public Single[] distanceAlongTrack; //Field offset: 0x28
	public int round; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 146
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SpawnBloonsOnRound() { }

	public SpawnBloonsOnRound(string bloonId, int count, Single[] distanceAlongTrack, int round) { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

