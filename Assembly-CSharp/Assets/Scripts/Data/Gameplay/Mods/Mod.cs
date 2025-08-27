namespace Assets.Scripts.Data.Gameplay.Mods;

[CreateAssetMenu(menuName = "BTD6/Mod")]
public class Mod : ScriptableObject
{
	[SerializeReference]
	public MutatorModModel[] mutatorMods; //Field offset: 0x18

	public ModModel Def
	{
		 get { } //Length: 114
	}

	public Mod() { }

	public ModModel get_Def() { }

}

