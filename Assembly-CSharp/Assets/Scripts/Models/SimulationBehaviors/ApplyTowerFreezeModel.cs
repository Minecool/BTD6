namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(ApplyTowerFreeze), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ApplyTowerFreezeModel : SimulationBehaviorModel
{
	public const string mutatorId = "TowerFreeze"; //Field offset: 0x0
	public int stunFrequencyRounds; //Field offset: 0x30
	public int stunDurationRounds; //Field offset: 0x34
	public String[] ignoreList; //Field offset: 0x38
	public PrefabReference towerStunEffect; //Field offset: 0x40
	public AudioClipReference freezeSound; //Field offset: 0x48
	private TowerFreezeMutator mutator; //Field offset: 0x50

	public TowerFreezeMutator Mutator
	{
		 get { } //Length: 150
	}

	public ApplyTowerFreezeModel(string name, int stunFrequencyRounds, int stunDurationRounds, String[] ignoreList, PrefabReference towerStunEffect, AudioClipReference freezeSound) { }

	public virtual Model Clone() { }

	public TowerFreezeMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

