namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MutationImunityTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MutationImunityTowerModel : TowerBehaviorModel
{
	public String[] mutationIds; //Field offset: 0x30
	public float effectScale; //Field offset: 0x38
	public float durationScale; //Field offset: 0x3C
	public bool modifyEffectScale; //Field offset: 0x40
	public bool modifyDurationScale; //Field offset: 0x41
	public bool preventMutation; //Field offset: 0x42

	public MutationImunityTowerModel(string name, String[] mutationIds, float effectScale, bool modifyEffectScale, float durationScale, bool modifyDurationScale, bool preventMutation) { }

	public bool CheckTower(BehaviorMutator mutation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

