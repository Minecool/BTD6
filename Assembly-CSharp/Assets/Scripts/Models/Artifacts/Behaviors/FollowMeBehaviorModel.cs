namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(FollowMeBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FollowMeBehaviorModel : ItemArtifactBehaviorModel
{
	internal class FollowMeBehaviorMutator : BehaviorMutator
	{
		private RotateToPointerModel rotateToPointerModel; //Field offset: 0x70
		private TargetSupplierModel targetSupplierModel; //Field offset: 0x78

		public FollowMeBehaviorMutator(string mutatorId, bool isUnique, RotateToPointerModel rotateToPointerModel, TargetSupplierModel targetSupplierModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[ExtendedDrawer]
	[SerializeReference]
	public TargetSupplierModel target; //Field offset: 0x30
	[ExtendedDrawer]
	[SerializeReference]
	public RotateToPointerModel rotate; //Field offset: 0x38
	public String[] towerTypes; //Field offset: 0x40
	public bool inverseTowerTypes; //Field offset: 0x48
	public TowerSet[] towerSets; //Field offset: 0x50
	public bool inverseTowerSet; //Field offset: 0x58
	public TowerSet towerSet; //Field offset: 0x5C

	public FollowMeBehaviorModel(string name, TargetSupplierModel target, RotateToPointerModel rotate, String[] towerTypes, bool inverseTowerTypes, TowerSet[] towerSets, bool inverseTowerSet) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

