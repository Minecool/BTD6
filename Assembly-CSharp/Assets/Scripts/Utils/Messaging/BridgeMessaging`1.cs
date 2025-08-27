namespace Assets.Scripts.Utils.Messaging;

public class BridgeMessaging : MessagingBase<T, BridgeMessaging`1<T>>
{

	protected virtual Warn<T, BridgeMessaging<T>> WarningMode
	{
		 get { } //Length: 6
	}

	public BridgeMessaging`1() { }

	protected virtual Warn<T, BridgeMessaging<T>> get_WarningMode() { }

	protected virtual void StartTracking() { }

	protected virtual void StopTracking() { }

}

