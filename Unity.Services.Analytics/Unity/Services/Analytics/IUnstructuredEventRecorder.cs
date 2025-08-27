namespace Unity.Services.Analytics;

internal interface IUnstructuredEventRecorder
{

	public void CustomData(string eventName, IDictionary<String, Object> eventParams, Nullable<Int32> eventVersion, bool includeCommonParams, bool includePlayerIds, string callingMethodIdentifier) { }

}

