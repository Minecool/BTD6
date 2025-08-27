namespace Assets.Scripts.Unity.Map;

public class ApplyTowerFreeze : MapSimulationBehavior
{
	public int stunFrequencyRounds; //Field offset: 0x20
	public int stunDurationRounds; //Field offset: 0x24
	public string ignoreList; //Field offset: 0x28
	public PrefabReference towerStunEffect; //Field offset: 0x30
	public AudioClipReference freezeSound; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 238
	}

	public ApplyTowerFreeze() { }

	public ApplyTowerFreeze(int stunFrequencyRounds, int stunDurationRounds, string ignoreList, PrefabReference towerStunEffect, AudioClipReference freezeSound) { }

	public virtual SimulationBehaviorModel get_Def() { }

}

