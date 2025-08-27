namespace Assets.Scripts.Simulation.Powers;

public class PowerManager : RootBehavior
{
	public List<PowerSaveDataModel> powerPlaceHistory; //Field offset: 0x58

	public PowerManager() { }

	public void Activate(Vector2 location, ref PowerModel model, int inputId) { }

	public void ActivateCustomMapSpawnedPower(Vector2 location, ref PowerModel model) { }

	public bool CheckLocation(Vector2 location, PowerModel model) { }

	private Power GetInstance(PowerBehaviorModel behavior) { }

	public List<PowerSaveDataModel> GetPowerPlaceHistorySaveData() { }

	public Projectile GetPowerProjectileFromId(ObjectId objectId, out PowerModel powerModel) { }

	public Tower GetPowerTowerFromId(ObjectId objectId, out PowerModel powerModel) { }

	public void SetPowerPlaceHistorySaveData(List<PowerSaveDataModel> saveData) { }

}

