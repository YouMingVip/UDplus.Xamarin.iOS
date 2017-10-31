//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace UDplus.Xamarin.iOS {
	[Register("MobClick", true)]
	public unsafe partial class MobClick : NSObject, global::UIKit.IUIAlertViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobClick");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobClick () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobClick (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobClick (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("beginEvent:")]
		[CompilerGenerated]
		public static void BeginEvent (string eventId)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			var nseventId = NSString.CreateNative (eventId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("beginEvent:"), nseventId);
			NSString.ReleaseNative (nseventId);
			
		}
		
		[Export ("beginEvent:label:")]
		[CompilerGenerated]
		public static void BeginEvent (string eventId, string label)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nseventId = NSString.CreateNative (eventId);
			var nslabel = NSString.CreateNative (label);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("beginEvent:label:"), nseventId, nslabel);
			NSString.ReleaseNative (nseventId);
			NSString.ReleaseNative (nslabel);
			
		}
		
		[Export ("beginEvent:primarykey:attributes:")]
		[CompilerGenerated]
		public static void BeginEvent (string eventId, string keyName, NSDictionary attributes)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			if (keyName == null)
				throw new ArgumentNullException ("keyName");
			if (attributes == null)
				throw new ArgumentNullException ("attributes");
			var nseventId = NSString.CreateNative (eventId);
			var nskeyName = NSString.CreateNative (keyName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("beginEvent:primarykey:attributes:"), nseventId, nskeyName, attributes.Handle);
			NSString.ReleaseNative (nseventId);
			NSString.ReleaseNative (nskeyName);
			
		}
		
		[Export ("beginLogPageView:")]
		[CompilerGenerated]
		public static void BeginLogPageView (string pageName)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("beginLogPageView:"), nspageName);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("endEvent:")]
		[CompilerGenerated]
		public static void EndEvent (string eventId)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			var nseventId = NSString.CreateNative (eventId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("endEvent:"), nseventId);
			NSString.ReleaseNative (nseventId);
			
		}
		
		[Export ("endEvent:label:")]
		[CompilerGenerated]
		public static void EndEvent (string eventId, string label)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nseventId = NSString.CreateNative (eventId);
			var nslabel = NSString.CreateNative (label);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("endEvent:label:"), nseventId, nslabel);
			NSString.ReleaseNative (nseventId);
			NSString.ReleaseNative (nslabel);
			
		}
		
		[Export ("endLogPageView:")]
		[CompilerGenerated]
		public static void EndLogPageView (string pageName)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("endLogPageView:"), nspageName);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("event:")]
		[CompilerGenerated]
		public static void Event (string eventId)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			var nseventId = NSString.CreateNative (eventId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("event:"), nseventId);
			NSString.ReleaseNative (nseventId);
			
		}
		
		[Export ("event:label:")]
		[CompilerGenerated]
		public static void Event (string eventId, string label)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nseventId = NSString.CreateNative (eventId);
			var nslabel = NSString.CreateNative (label);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("event:label:"), nseventId, nslabel);
			NSString.ReleaseNative (nseventId);
			NSString.ReleaseNative (nslabel);
			
		}
		
		[Export ("event:attributes:")]
		[CompilerGenerated]
		public static void Event (string eventId, NSDictionary attributes)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			if (attributes == null)
				throw new ArgumentNullException ("attributes");
			var nseventId = NSString.CreateNative (eventId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("event:attributes:"), nseventId, attributes.Handle);
			NSString.ReleaseNative (nseventId);
			
		}
		
		[Export ("event:attributes:counter:")]
		[CompilerGenerated]
		public static void Event (string eventId, NSDictionary attributes, int number)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			if (attributes == null)
				throw new ArgumentNullException ("attributes");
			var nseventId = NSString.CreateNative (eventId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_int (class_ptr, Selector.GetHandle ("event:attributes:counter:"), nseventId, attributes.Handle, number);
			NSString.ReleaseNative (nseventId);
			
		}
		
		[Export ("event:durations:")]
		[CompilerGenerated]
		public static void Event (string eventId, int millisecond)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			var nseventId = NSString.CreateNative (eventId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("event:durations:"), nseventId, millisecond);
			NSString.ReleaseNative (nseventId);
			
		}
		
		[Export ("event:value:label:")]
		[CompilerGenerated]
		public static void Event (NSObject[] keyPath, int value, string label)
		{
			if (keyPath == null)
				throw new ArgumentNullException ("keyPath");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nsa_keyPath = NSArray.FromNSObjects (keyPath);
			var nslabel = NSString.CreateNative (label);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (class_ptr, Selector.GetHandle ("event:value:label:"), nsa_keyPath.Handle, value, nslabel);
			nsa_keyPath.Dispose ();
			NSString.ReleaseNative (nslabel);
			
		}
		
		[Export ("logPageView:seconds:")]
		[CompilerGenerated]
		public static void LogPageView (string pageName, int seconds)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("logPageView:seconds:"), nspageName, seconds);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("profileSignInWithPUID:")]
		[CompilerGenerated]
		public static void ProfileSignInWithPUID (string puid)
		{
			if (puid == null)
				throw new ArgumentNullException ("puid");
			var nspuid = NSString.CreateNative (puid);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("profileSignInWithPUID:"), nspuid);
			NSString.ReleaseNative (nspuid);
			
		}
		
		[Export ("profileSignInWithPUID:provider:")]
		[CompilerGenerated]
		public static void ProfileSignInWithPUID (string puid, string provider)
		{
			if (puid == null)
				throw new ArgumentNullException ("puid");
			if (provider == null)
				throw new ArgumentNullException ("provider");
			var nspuid = NSString.CreateNative (puid);
			var nsprovider = NSString.CreateNative (provider);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("profileSignInWithPUID:provider:"), nspuid, nsprovider);
			NSString.ReleaseNative (nspuid);
			NSString.ReleaseNative (nsprovider);
			
		}
		
		[Export ("profileSignOff")]
		[CompilerGenerated]
		public static void ProfileSignOff ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("profileSignOff"));
		}
		
		[Export ("setAppVersion:")]
		[CompilerGenerated]
		public static void SetAppVersion (string appVersion)
		{
			if (appVersion == null)
				throw new ArgumentNullException ("appVersion");
			var nsappVersion = NSString.CreateNative (appVersion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setAppVersion:"), nsappVersion);
			NSString.ReleaseNative (nsappVersion);
			
		}
		
		[Export ("setCrashCBBlock:")]
		[CompilerGenerated]
		public unsafe static void SetCrashCBBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCallbackBlock))]CallbackBlock cbBlock)
		{
			if (cbBlock == null)
				throw new ArgumentNullException ("cbBlock");
			BlockLiteral *block_ptr_cbBlock;
			BlockLiteral block_cbBlock;
			block_cbBlock = new BlockLiteral ();
			block_ptr_cbBlock = &block_cbBlock;
			block_cbBlock.SetupBlock (Trampolines.SDCallbackBlock.Handler, cbBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setCrashCBBlock:"), (IntPtr) block_ptr_cbBlock);
			block_ptr_cbBlock->CleanupBlock ();
			
		}
		
		[Export ("setCrashReportEnabled:")]
		[CompilerGenerated]
		public static void SetCrashReportEnabled (bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setCrashReportEnabled:"), value);
		}
		
		[Export ("setEncryptEnabled:")]
		[Introduced (PlatformName.iOS, 2,0)]
		[Deprecated (PlatformName.iOS, 5,0)]
		[CompilerGenerated]
		public static void SetEncryptEnabled (bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEncryptEnabled:"), value);
		}
		
		[Export ("setLatitude:longitude:")]
		[CompilerGenerated]
		public static void SetLatitude (global::System.Double latitude, global::System.Double longitude)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_Double (class_ptr, Selector.GetHandle ("setLatitude:longitude:"), latitude, longitude);
		}
		
		[Export ("setLocation:")]
		[CompilerGenerated]
		public static void SetLocation (global::CoreLocation.CLLocation location)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setLocation:"), location.Handle);
		}
		
		[Export ("setLogEnabled:")]
		[Introduced (PlatformName.iOS, 2,0)]
		[Deprecated (PlatformName.iOS, 5,0)]
		[CompilerGenerated]
		public static void SetLogEnabled (bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setLogEnabled:"), value);
		}
		
		[Export ("setLogSendInterval:")]
		[CompilerGenerated]
		public static void SetLogSendInterval (global::System.Double second)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double (class_ptr, Selector.GetHandle ("setLogSendInterval:"), second);
		}
		
		[Export ("setReportPolicy:")]
		[CompilerGenerated]
		public static void SetReportPolicy (int ePolicy)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setReportPolicy:"), ePolicy);
		}
		
		[Export ("setScenarioType:")]
		[CompilerGenerated]
		public static void SetScenarioType (eScenarioType eSType)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (class_ptr, Selector.GetHandle ("setScenarioType:"), (Int64)eSType);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setScenarioType:"), (int)eSType);
			}
		}
		
		[Export ("setSecret:")]
		[CompilerGenerated]
		public static void SetSecret (string secret)
		{
			if (secret == null)
				throw new ArgumentNullException ("secret");
			var nssecret = NSString.CreateNative (secret);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setSecret:"), nssecret);
			NSString.ReleaseNative (nssecret);
			
		}
		
		[CompilerGenerated]
		public static bool IsJailbroken {
			[Export ("isJailbroken")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isJailbroken"));
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsPirated {
			[Export ("isPirated")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isPirated"));
			}
			
		}
		
	} /* class MobClick */
}
