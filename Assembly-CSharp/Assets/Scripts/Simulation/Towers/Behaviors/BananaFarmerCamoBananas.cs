namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BananaFarmerCamoBananas : TowerBehavior
{
	public BananaFarmerCamoBananasModel bananaFarmerCamoBananasModel; //Field offset: 0x68
	private Zoned<Tower> zone; //Field offset: 0x70

	public BananaFarmerCamoBananas() { }

	[CompilerGenerated]
	private float <Initialise>b__2_0() { }

	[CompilerGenerated]
	private float <UpdatedModel>b__3_0() { }

	[CompilerGenerated]
	private float <UpdatedModel>b__3_1() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void TowerEnter(Tower tower) { }

	private void TowerExit(Tower tower) { }

	private bool TowerFilter(RootBehavior behavior) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

