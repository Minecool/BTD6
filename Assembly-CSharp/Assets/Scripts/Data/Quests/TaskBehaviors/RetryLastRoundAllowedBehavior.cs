namespace Assets.Scripts.Data.Quests.TaskBehaviors;

public class RetryLastRoundAllowedBehavior : TaskBehavior
{
	internal struct MonkeyMoneyCostForRoundBracket
	{
		public int round; //Field offset: 0x0
		public int mmCost; //Field offset: 0x4

	}

	public int baseMmCost; //Field offset: 0x10
	public bool retryFromCheckpointAllowedOnly; //Field offset: 0x14
	public MonkeyMoneyCostForRoundBracket[] mmRetryCostPerRoundBracket; //Field offset: 0x18

	public RetryLastRoundAllowedBehavior() { }

	public int GetMmRetryCostForRound(int round, out int roundBracketSelected) { }

}

