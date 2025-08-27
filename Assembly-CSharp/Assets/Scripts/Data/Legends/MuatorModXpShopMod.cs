namespace Assets.Scripts.Data.Legends;

public class MuatorModXpShopMod : RogueXpShopMod
{
	public string modName; //Field offset: 0x10

	public MuatorModXpShopMod() { }

	public virtual string GetMutatorModName() { }

}

