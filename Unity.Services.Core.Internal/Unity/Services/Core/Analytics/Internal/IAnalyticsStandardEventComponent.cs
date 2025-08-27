namespace Unity.Services.Core.Analytics.Internal;

public interface IAnalyticsStandardEventComponent : IServiceComponent
{

	public void Record(string eventName, IDictionary<String, Object> eventParameters, int eventVersion, string packageName) { }

}

