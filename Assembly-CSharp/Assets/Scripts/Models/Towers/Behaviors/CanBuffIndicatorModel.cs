namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CanBuffIndicator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CanBuffIndicatorModel : TowerBehaviorBuffModel
{
	public bool isDisabled; //Field offset: 0x48

	public CanBuffIndicatorModel(string name, string buffLocsName, string buffIconName, bool isDisabled, bool isGlobalRange = false, int maxStackSize = 0) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

