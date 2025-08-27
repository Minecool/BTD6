namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "SpawnBloonsOnRound", menuName = "BTD6/Behaviors/Simulations/SpawnBloonsOnRound")]
public class SpawnBloonsOnRound : SimulationBehavior
{
	[BloonType]
	public string bloonId; //Field offset: 0x30
	public int count; //Field offset: 0x38
	public Single[] distanceAlongTrack; //Field offset: 0x40
	public int round; //Field offset: 0x48

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 146
	}

	public SpawnBloonsOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

