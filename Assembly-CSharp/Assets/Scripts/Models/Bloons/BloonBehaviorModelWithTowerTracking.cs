namespace Assets.Scripts.Models.Bloons;

public abstract class BloonBehaviorModelWithTowerTracking : BloonBehaviorModel
{
	public ObjectId tower; //Field offset: 0x30

	protected BloonBehaviorModelWithTowerTracking() { }

	protected BloonBehaviorModelWithTowerTracking(string name, ObjectId tower) { }

	public Tower GetTower(Simulation sim) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

