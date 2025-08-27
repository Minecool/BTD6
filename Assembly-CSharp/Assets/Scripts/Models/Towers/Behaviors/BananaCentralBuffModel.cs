namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BananaCentralBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BananaCentralBuffModel : TowerBehaviorBuffModel
{
	public float multiplier; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50

	public BananaCentralBuffModel(string name, float multiplier, string mutatorId, string buffLocsName, string buffIconName, bool isGlobalRange) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

