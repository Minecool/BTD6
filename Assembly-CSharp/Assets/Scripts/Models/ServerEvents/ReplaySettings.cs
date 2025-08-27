namespace Assets.Scripts.Models.ServerEvents;

public class ReplaySettings : EnableFlag
{
	public bool enforceUpload; //Field offset: 0x18
	public bool recordCoop; //Field offset: 0x19
	public int submissionRankThreshold; //Field offset: 0x1C
	public GameType[] gameTypes; //Field offset: 0x20
	public TimeSpan replayExpiry; //Field offset: 0x28
	public int cursorUpdateInterval; //Field offset: 0x30
	public int markerFrequency; //Field offset: 0x34

	public ReplaySettings() { }

}

