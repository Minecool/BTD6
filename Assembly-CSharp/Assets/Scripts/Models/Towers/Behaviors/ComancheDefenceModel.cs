namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ComancheDefence), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ComancheDefenceModel : TowerBehaviorModel
{
	public TowerModel towerModel; //Field offset: 0x30
	public int reinforcementCount; //Field offset: 0x38
	public int durationFrames; //Field offset: 0x3C
	public int cooldownFrames; //Field offset: 0x40
	public int maxActivationsPerRound; //Field offset: 0x44
	public bool immediate; //Field offset: 0x48
	public SoundModel sound; //Field offset: 0x50

	public ComancheDefenceModel(string name, TowerModel towerModel, int reinforcementCount, int durationFrames, int cooldownFrames, bool immediate, SoundModel sound, int maxActivationsPerRound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

