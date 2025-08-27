namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(UCAV), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class UCAVModel : AbilityBehaviorModel
{
	[SerializeField]
	private float duration; //Field offset: 0x30
	public int durationFrames; //Field offset: 0x34
	public TowerModel uavTowerModel; //Field offset: 0x38
	public TowerModel ucavTowerModel; //Field offset: 0x40
	public EffectModel effectAtTowerEndModel; //Field offset: 0x48

	public UCAVModel(string name, float duration, TowerModel uavTowerModel, TowerModel ucavTowerModel, EffectModel effectAtTowerEndModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

