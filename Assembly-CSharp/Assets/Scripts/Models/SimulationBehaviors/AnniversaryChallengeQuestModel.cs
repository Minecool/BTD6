namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(AnniversaryChallengeQuest), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AnniversaryChallengeQuestModel : RushChallengeManagerModel
{

	public AnniversaryChallengeQuestModel(string targetBloonName, float badSpeedMutliplier, float badScaleMutliplier, float badHealthMutliplier, int numAllowedLeaks, int numRoundsBeforeSpawningTarget) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

