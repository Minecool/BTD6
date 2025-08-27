namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AbilityCooldownScaleSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AbilityCooldownScaleSupportModel : SupportModel
{
	public bool isUnique; //Field offset: 0x60
	public float abilityCooldownSpeedScale; //Field offset: 0x64
	public bool affectsOnlyWater; //Field offset: 0x68
	public int mutatorPriority; //Field offset: 0x6C

	public AbilityCooldownScaleSupportModel(string name, bool isUnique, float abilityCooldownSpeedScale, bool affectsOnlyWater, bool isGlobal, TowerFilterModel[] filters, string buffLocsName, string buffIconName, bool onlyShowBuffIfMutated = false, int mutatorPriority = 1, bool onlyAffectParagon = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

