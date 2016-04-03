package md563bb5d7cd114ceda82ec85fb57ce3637;


public class PushNotificationGcmListener
	extends com.google.android.gms.gcm.GcmListenerService
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMessageReceived:(Ljava/lang/String;Landroid/os/Bundle;)V:GetOnMessageReceived_Ljava_lang_String_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("PushNotification.Plugin.PushNotificationGcmListener, PushNotification.Plugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PushNotificationGcmListener.class, __md_methods);
	}


	public PushNotificationGcmListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PushNotificationGcmListener.class)
			mono.android.TypeManager.Activate ("PushNotification.Plugin.PushNotificationGcmListener, PushNotification.Plugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMessageReceived (java.lang.String p0, android.os.Bundle p1)
	{
		n_onMessageReceived (p0, p1);
	}

	private native void n_onMessageReceived (java.lang.String p0, android.os.Bundle p1);

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
