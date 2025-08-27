namespace Assets.Scripts.Models.TowerSets;

public class TowerDetailsModel : Model
{
	public string towerId; //Field offset: 0x30
	public int towerIndex; //Field offset: 0x38
	public int towerCount; //Field offset: 0x3C

	public TowerDetailsModel(string towerId, int towerIndex, int towerCount) { }

	public virtual Model Clone() { }

	public bool IsAvailable() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

