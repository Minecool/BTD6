namespace Assets.Scripts.Data.Boss;

[CreateAssetMenu(fileName = "BossRushBloonData", menuName = "BTD6/RushBloon")]
public class BossRushScriptable : ScriptableObject
{
	public BossType bossType; //Field offset: 0x18
	public int cashReward; //Field offset: 0x1C
	public float cashRewardMultiplier; //Field offset: 0x20
	public int maxCashScalingLevel; //Field offset: 0x24
	[SerializeReference]
	public BloonBehaviorModel[] behaviorModels; //Field offset: 0x28

	public BossRushScriptable() { }

}

