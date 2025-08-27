namespace Assets.Scripts.Simulation.Behaviors;

public class DestroyOnTowerSold : RootBehavior
{
	public Tower tower; //Field offset: 0x58

	public Tower Tower
	{
		 set { } //Length: 239
	}

	public DestroyOnTowerSold() { }

	private void Kill(RootObject obj) { }

	private void Kill2() { }

	protected virtual void OnDestroy() { }

	public void set_Tower(Tower value) { }

}

