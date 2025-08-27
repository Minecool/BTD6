namespace Assets.Scripts.Models.ServerEvents;

public class Coop : EnableFlag
{
	internal class ConnectionSettings
	{
		internal class BluePopup
		{
			public TimeSpan startingTimeTillKick; //Field offset: 0x10
			public TimeSpan timeTillKick; //Field offset: 0x18
			public TimeSpan recentPeriod; //Field offset: 0x20
			public int totalStrikesTillKick; //Field offset: 0x28
			public int recentStrikesTillKick; //Field offset: 0x2C
			public float tolerance; //Field offset: 0x30

			public BluePopup() { }

		}

		internal class BufferSizes
		{
			public int receiveBytes; //Field offset: 0x10

			public BufferSizes() { }

		}

		internal class LatencyCheck
		{
			public TimeSpan interval; //Field offset: 0x10
			public TimeSpan warning; //Field offset: 0x18
			public TimeSpan timeout; //Field offset: 0x20
			public int maxFailsInLobby; //Field offset: 0x28

			public LatencyCheck() { }

		}

		internal class LatencyHistory
		{
			public int numSamples; //Field offset: 0x10

			public LatencyHistory() { }

		}

		internal class Reconnect
		{
			public TimeSpan interval; //Field offset: 0x10
			public int maxAttempts; //Field offset: 0x18

			public Reconnect() { }

		}

		internal class Rejoin
		{
			public TimeSpan testPeriod; //Field offset: 0x10
			public TimeSpan confirmationPeriod; //Field offset: 0x18

			public Rejoin() { }

		}

		public Reconnect reconnect; //Field offset: 0x10
		public Rejoin rejoin; //Field offset: 0x18
		public LatencyCheck latencyCheck; //Field offset: 0x20
		public BluePopup bluePopup; //Field offset: 0x28
		public LatencyHistory latencyHistory; //Field offset: 0x30
		public BufferSizes bufferSizes; //Field offset: 0x38

		public ConnectionSettings() { }

	}

	internal class Hackers
	{
		public TimeSpan checkInterval; //Field offset: 0x10

		public Hackers() { }

	}

	public QuickMatchSkuSettings quickMatch; //Field offset: 0x18
	public TimerSkuSettings timerSettings; //Field offset: 0x20
	public NetworkVariables networkVariables; //Field offset: 0x28
	public ConnectionSettings connection; //Field offset: 0x30
	public Hackers hackers; //Field offset: 0x38
	public CoopInviteSettings invites; //Field offset: 0x40
	public int compatibility; //Field offset: 0x48
	public String[] compatibleVersions; //Field offset: 0x50
	public int coopUnlockLevel; //Field offset: 0x58
	public int freeplayTimer; //Field offset: 0x5C
	public TimeSpan lobbySyncTimeout; //Field offset: 0x60
	public TimeSpan maxLobbyTime; //Field offset: 0x68

	public Coop() { }

}

