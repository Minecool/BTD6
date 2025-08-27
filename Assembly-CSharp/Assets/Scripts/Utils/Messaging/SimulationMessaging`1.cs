namespace Assets.Scripts.Utils.Messaging;

public class SimulationMessaging : MessagingBase<T, SimulationMessaging`1<T>>
{

	protected virtual Warn<T, SimulationMessaging<T>> WarningMode
	{
		 get { } //Length: 6
	}

	public SimulationMessaging`1() { }

	protected virtual Warn<T, SimulationMessaging<T>> get_WarningMode() { }

	protected virtual void StartTracking() { }

	protected virtual void StopTracking() { }

}

