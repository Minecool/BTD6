namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewAnniversaryChallengeQuest", menuName = "BTD6/Behaviors/Simulations/AnniversaryChallengeQuest")]
public class AnniversaryChallengeQuest : SimulationBehavior
{
	public string targetBloonName; //Field offset: 0x30
	public float badHealthMutliplier; //Field offset: 0x38
	public float badSpeedMutliplier; //Field offset: 0x3C
	public float badScaleMutliplier; //Field offset: 0x40
	public int numAllowedLeaks; //Field offset: 0x44
	public int numRoundsBeforeSpawningTarget; //Field offset: 0x48

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 189
	}

	public AnniversaryChallengeQuest() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

