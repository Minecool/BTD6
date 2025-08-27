namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PoplustSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PoplustSupportModel : TowerBehaviorBuffModel
{
	public string mutatorId; //Field offset: 0x48
	public int maxStacks; //Field offset: 0x50
	public float ratePercentIncrease; //Field offset: 0x54
	public float piercePercentIncrease; //Field offset: 0x58

	public PoplustSupportModel(string name, string mutatorId, int maxStacks, float ratePercentIncrease, float piercePercentIncrease, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

