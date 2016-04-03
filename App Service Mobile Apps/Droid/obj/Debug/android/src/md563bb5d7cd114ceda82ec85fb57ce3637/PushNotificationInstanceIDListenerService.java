package md563bb5d7cd114ceda82ec85fb57ce3637;


public class PushNotificationInstanceIDListenerService
	extends com.google.android.gms.iid.InstanceIDListenerService
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTokenRefresh:()V:GetOnTokenRefreshHandler\n" +
			"";
		mono.android.Runtime.register ("PushNotification.Plugin.PushNotificationInstanceIDListenerService, PushNotification.Plugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PushNotificationInstanceIDListenerService.class, __md_methods);
	}


	public PushNotificationInstanceIDListenerService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PushNotificationInstanceIDListenerService.class)
			mono.android.TypeManager.Activate ("PushNotification.Plugin.PushNotificationInstanceIDListenerService, PushNotification.Plugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTokenRefresh ()
	{
		n_onTokenRefresh ();
	}

	private native void n_onTokenRefresh ();

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
