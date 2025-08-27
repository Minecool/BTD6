namespace Assets.Scripts.Data.AnimatedCharacters;

public class QuestCharacter : ScriptableObject
{
	public string id; //Field offset: 0x18
	public PrefabReference character; //Field offset: 0x20
	public bool disableNamePlate; //Field offset: 0x28

	public QuestCharacter() { }

}

