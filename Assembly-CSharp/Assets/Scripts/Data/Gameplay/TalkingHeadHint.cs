namespace Assets.Scripts.Data.Gameplay;

[CreateAssetMenu(menuName = "BTD6/Talking Head Hint")]
public class TalkingHeadHint : ScriptableObject
{
	public string id; //Field offset: 0x18
	public DialogueDataQuest dialogueData; //Field offset: 0x20

	public TalkingHeadHint() { }

}

