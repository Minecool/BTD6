namespace Assets.Scripts.Data.Legends;

[CreateAssetMenu(fileName = "RogueBloonModifierData", menuName = "BTD6/RogueBloonModifierData")]
public class RogueBloonModifierData : ScriptableObject
{
	public RogueBloonModifier modifier; //Field offset: 0x18
	public int minimumStage; //Field offset: 0x1C
	public PrefabReference tileDisplay; //Field offset: 0x20
	public string roundSet; //Field offset: 0x28
	public string locKey; //Field offset: 0x30
	[SerializeReference]
	public MutatorModModel[] mods; //Field offset: 0x38

	public RogueBloonModifierData() { }

}

