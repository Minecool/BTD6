namespace Assets.Scripts.Data.GeraldoItems;

public class SyncedPet : ScriptableObject
{
	public bool isFlying; //Field offset: 0x18
	public PrefabReference display; //Field offset: 0x20
	[SerializeField]
	[SerializeReference]
	private IUIBehavior[] behaviours; //Field offset: 0x28
	private PetModelSynced def; //Field offset: 0x30

	public PetModelSynced Def
	{
		 get { } //Length: 214
	}

	public SyncedPet() { }

	public PetModelSynced get_Def() { }

}

