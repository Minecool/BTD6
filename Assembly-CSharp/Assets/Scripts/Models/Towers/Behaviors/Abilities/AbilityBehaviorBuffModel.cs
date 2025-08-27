namespace Assets.Scripts.Models.Towers.Behaviors.Abilities;

public abstract class AbilityBehaviorBuffModel : AbilityBehaviorModel
{
	public bool showBuffIcon; //Field offset: 0x30
	public bool isGlobal; //Field offset: 0x31
	public string buffLocsName; //Field offset: 0x38
	public string buffIconName; //Field offset: 0x40

	protected AbilityBehaviorBuffModel(string name, bool isGlobal = false, string buffLocsName = "", string buffIconName = "", int maxStackSize = 0) { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

}

