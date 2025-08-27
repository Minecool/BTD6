namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SyncCamoDetectionWithTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SyncCamoDetectionWithTowerModel : ProjectileBehaviorModel
{
	internal class VisibilityMutator : BehaviorMutator
	{

		public VisibilityMutator() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private VisibilityMutator mutator; //Field offset: 0x38

	public VisibilityMutator Mutator
	{
		 get { } //Length: 211
	}

	public SyncCamoDetectionWithTowerModel(string name) { }

	public virtual Model Clone() { }

	public VisibilityMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

