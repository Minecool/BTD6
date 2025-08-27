namespace Assets.Scripts.Models.ServerEvents;

public class TimerSkuSettings
{
	public TimeSpan maxLobbyWait; //Field offset: 0x10
	public TimeSpan lobbyStartWait; //Field offset: 0x18
	public TimeSpan defeatScreenWait; //Field offset: 0x20
	public TimeSpan idleLobbyExpire; //Field offset: 0x28
	public TimeSpan mapLoadTimeout; //Field offset: 0x30
	public TimeSpan rejoinPromptExpire; //Field offset: 0x38

	public TimerSkuSettings() { }

}

