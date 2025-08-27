namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AbilityCooldownScaleSupport : SupportBehavior
{
	public AbilityCooldownScaleSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float abilityCooldownSpeedScale; //Field offset: 0xE0
	public string expAbilityCooldownSpeedScale; //Field offset: 0xE8
	public bool affectsOnlyWater; //Field offset: 0xF0
	public string expAffectsOnlyWater; //Field offset: 0xF8
	public bool isGlobal; //Field offset: 0x100
	public string expIsGlobal; //Field offset: 0x108
	public bool onlyShowBuffIconIfMutated; //Field offset: 0x110
	public string expOnlyShowBuffIconIfMutated; //Field offset: 0x118

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 275
	}

	public AbilityCooldownScaleSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

