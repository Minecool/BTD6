namespace Assets.Scripts.Models.Towers.Behaviors;

public abstract class SupportModel : TowerBehaviorModel
{
	public TowerFilterModel[] filters; //Field offset: 0x30
	public bool isGlobal; //Field offset: 0x38
	public bool isCustomRadius; //Field offset: 0x39
	public float customRadius; //Field offset: 0x3C
	public bool appliesToOwningTower; //Field offset: 0x40
	public bool showBuffIcon; //Field offset: 0x41
	public string buffLocsName; //Field offset: 0x48
	public string buffIconName; //Field offset: 0x50
	public int maxStackSize; //Field offset: 0x58
	public bool onlyShowBuffIfMutated; //Field offset: 0x5C
	public bool onlyAffectParagon; //Field offset: 0x5D

	protected SupportModel(string name, TowerFilterModel[] filters, bool isGlobal, bool isCustomRadius = false, float customRadius = 0, bool appliesToOwningTower = false, string buffLocsName = "", string buffIconName = "", int maxStackSize = 0, bool onlyShowBuffIfMutated = false, bool onlyAffectParagon = false) { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

}

