namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(FreezeNearbyWater), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FreezeNearbyWaterModel : TowerBehaviorModel
{
	internal class AddBehaviorToIceTowerMutator : BehaviorMutator
	{
		public const string mutatorId = "DisplayModel_FreezeWater"; //Field offset: 0x0
		public DisplayModel displayModel; //Field offset: 0x70
		public ShowDisplayForTerrainModel showDisplayTerrainModel; //Field offset: 0x78

		public AddBehaviorToIceTowerMutator(DisplayModel displayModel, ShowDisplayForTerrainModel showDisplayTerrainModel, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float radius; //Field offset: 0x30
	public float areaHeightOffset; //Field offset: 0x34
	public PrefabReference freezeAsset; //Field offset: 0x38
	public int displayPriority; //Field offset: 0x40

	public FreezeNearbyWaterModel(string name, float radius, float areaHeightOffset, PrefabReference freezeAsset, int displayPriority) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

