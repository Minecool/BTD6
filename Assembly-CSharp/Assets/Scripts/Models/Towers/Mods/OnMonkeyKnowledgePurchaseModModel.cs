namespace Assets.Scripts.Models.Towers.Mods;

public class OnMonkeyKnowledgePurchaseModModel : MutatorModModel
{
	public string towers; //Field offset: 0x30
	public float xpToAdd; //Field offset: 0x38

	public OnMonkeyKnowledgePurchaseModModel(string name, string towers, float xpToAdd) { }

	public virtual Model Clone() { }

}

