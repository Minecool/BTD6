namespace Assets.Scripts.Models.ServerEvents;

public class QuestEventMetadata : NewsPanelBackgroundMetadata
{
	public string rewards; //Field offset: 0x18
	public TimeSpan canStartUpTo; //Field offset: 0x20

	public QuestEventMetadata() { }

}

