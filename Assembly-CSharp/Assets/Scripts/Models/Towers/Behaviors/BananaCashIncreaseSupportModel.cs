namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BananaCashIncreaseSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BananaCashIncreaseSupportModel : SupportModel
{
	public float multiplier; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70
	public bool useTiers; //Field offset: 0x71
	public int firstPathTier; //Field offset: 0x74
	public int secondPathTier; //Field offset: 0x78
	public int thirdPathTier; //Field offset: 0x7C

	public BananaCashIncreaseSupportModel(string name, bool isUnique, float multiplier, string mutatorId, TowerFilterModel[] filters, bool useTiers, int firstPathTier, int secondPathTier, int thirdPathTier, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

