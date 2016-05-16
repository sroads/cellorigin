// Generated by github.com/davyxu/protoc-gen-sharpnet
// DO NOT EDIT!
// Source: login.proto
namespace gamedef
{
	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginREQ")]
	public partial class LoginREQ : global::ProtoBuf.IExtensible
	{
		public LoginREQ() {}
		
		string _PlatformToken = "";
		bool _hasPlatformToken = false;
		[global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PlatformToken", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string PlatformToken
		{
			get { return _PlatformToken; }
			set { _PlatformToken = value; 
			      _hasPlatformToken = true;
			}
		}
		
		public bool HasPlatformToken
		{
			get { return _hasPlatformToken; }
			set { _hasPlatformToken = value; }
		}
		
		string _PlatformUID = "";
		bool _hasPlatformUID = false;
		[global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PlatformUID", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string PlatformUID
		{
			get { return _PlatformUID; }
			set { _PlatformUID = value; 
			      _hasPlatformUID = true;
			}
		}
		
		public bool HasPlatformUID
		{
			get { return _hasPlatformUID; }
			set { _hasPlatformUID = value; }
		}
		
		string _PlatformName = "";
		bool _hasPlatformName = false;
		[global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PlatformName", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string PlatformName
		{
			get { return _PlatformName; }
			set { _PlatformName = value; 
			      _hasPlatformName = true;
			}
		}
		
		public bool HasPlatformName
		{
			get { return _hasPlatformName; }
			set { _hasPlatformName = value; }
		}
		
		string _ClientVersion = "";
		bool _hasClientVersion = false;
		[global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ClientVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string ClientVersion
		{
			get { return _ClientVersion; }
			set { _ClientVersion = value; 
			      _hasClientVersion = true;
			}
		}
		
		public bool HasClientVersion
		{
			get { return _hasClientVersion; }
			set { _hasClientVersion = value; }
		}
		
		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{ return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
	}
	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ServerInfo")]
	public partial class ServerInfo : global::ProtoBuf.IExtensible
	{
		public ServerInfo() {}
		
		string _Name = "";
		bool _hasName = false;
		[global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Name
		{
			get { return _Name; }
			set { _Name = value; 
			      _hasName = true;
			}
		}
		
		public bool HasName
		{
			get { return _hasName; }
			set { _hasName = value; }
		}
		
		string _DisplayName = "";
		bool _hasDisplayName = false;
		[global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DisplayName", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string DisplayName
		{
			get { return _DisplayName; }
			set { _DisplayName = value; 
			      _hasDisplayName = true;
			}
		}
		
		public bool HasDisplayName
		{
			get { return _hasDisplayName; }
			set { _hasDisplayName = value; }
		}
		
		string _Address = "";
		bool _hasAddress = false;
		[global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Address
		{
			get { return _Address; }
			set { _Address = value; 
			      _hasAddress = true;
			}
		}
		
		public bool HasAddress
		{
			get { return _hasAddress; }
			set { _hasAddress = value; }
		}
		
		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{ return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
	}
	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginACK")]
	public partial class LoginACK : global::ProtoBuf.IExtensible
	{
		public LoginACK() {}
		
		string _Result = "";
		bool _hasResult = false;
		[global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Result
		{
			get { return _Result; }
			set { _Result = value; 
			      _hasResult = true;
			}
		}
		
		public bool HasResult
		{
			get { return _hasResult; }
			set { _hasResult = value; }
		}
		
		string _Token = "";
		bool _hasToken = false;
		[global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Token", DataFormat = global::ProtoBuf.DataFormat.Default)]
		[global::System.ComponentModel.DefaultValue("")]
		public string Token
		{
			get { return _Token; }
			set { _Token = value; 
			      _hasToken = true;
			}
		}
		
		public bool HasToken
		{
			get { return _hasToken; }
			set { _hasToken = value; }
		}
		
		readonly global::System.Collections.Generic.List<gamedef.ServerInfo> _ServerList = new global::System.Collections.Generic.List<gamedef.ServerInfo>();
		[global::ProtoBuf.ProtoMember(3, Name=@"ServerList", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public global::System.Collections.Generic.List<gamedef.ServerInfo> ServerList
		{
			get { return _ServerList; }
		}
		
		
		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{ return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
	}
	
}
