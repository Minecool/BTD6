namespace Assets.Scripts.Data.Cosmetics.Pets;

public class Pet : AssetChangeItem
{
	public string towerId; //Field offset: 0x20
	public string skinId; //Field offset: 0x28
	public bool isFlying; //Field offset: 0x30
	public PrefabReference display; //Field offset: 0x38
	[SerializeReference]
	private IUIBehavior[] behaviours; //Field offset: 0x40
	private PetModelUnsynced def; //Field offset: 0x48

	public PetModelUnsynced Def
	{
		 get { } //Length: 214
	}

	public Pet() { }

	public PetModelUnsynced get_Def() { }

}

