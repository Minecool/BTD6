namespace Assets.Scripts.Data.Quests;

public class QuestDialogueAnimData
{
	public Characters leftMonkey; //Field offset: 0x10
	public Characters rightMonkey; //Field offset: 0x14
	public DialogueEmotions leftAnimKey; //Field offset: 0x18
	public DialogueEmotions rightAnimKey; //Field offset: 0x1C
	public DialogueTalkingState talkingKey; //Field offset: 0x20
	public string actionId; //Field offset: 0x28
	public string dialogueLoc; //Field offset: 0x30

	public QuestDialogueAnimData() { }

	public DialogueFrameAnimations GetFrameAnimKey(QuestDialogueAnimData previousAnim = null, bool finalFrame = false) { }

	public QuestCharacter GetLeftMonkeyData() { }

	public QuestCharacter GetRightMonkeyData() { }

}

