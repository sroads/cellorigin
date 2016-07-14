﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PBStreamReaderWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PBStreamReader), typeof(System.Object));
		L.RegFunction("ReadField", ReadField);
		L.RegFunction("ReadInt32", ReadInt32);
		L.RegFunction("ReadFloat", ReadFloat);
		L.RegFunction("ReadBool", ReadBool);
		L.RegFunction("ReadString", ReadString);
		L.RegFunction("BeginMessage", BeginMessage);
		L.RegFunction("EndMessage", EndMessage);
		L.RegFunction("New", _CreatePBStreamReader);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePBStreamReader(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				PBStreamReader obj = new PBStreamReader(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PBStreamReader.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadField(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PBStreamReader obj = (PBStreamReader)ToLua.CheckObject(L, 1, typeof(PBStreamReader));
			Descriptor arg0 = (Descriptor)ToLua.CheckObject(L, 2, typeof(Descriptor));
			FieldDescriptor o = obj.ReadField(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadInt32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PBStreamReader obj = (PBStreamReader)ToLua.CheckObject(L, 1, typeof(PBStreamReader));
			int arg0;
			bool o = obj.ReadInt32(out arg0);
			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushinteger(L, arg0);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadFloat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PBStreamReader obj = (PBStreamReader)ToLua.CheckObject(L, 1, typeof(PBStreamReader));
			float arg0;
			bool o = obj.ReadFloat(out arg0);
			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushnumber(L, arg0);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PBStreamReader obj = (PBStreamReader)ToLua.CheckObject(L, 1, typeof(PBStreamReader));
			bool arg0;
			bool o = obj.ReadBool(out arg0);
			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushboolean(L, arg0);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PBStreamReader obj = (PBStreamReader)ToLua.CheckObject(L, 1, typeof(PBStreamReader));
			string arg0 = null;
			bool o = obj.ReadString(out arg0);
			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushstring(L, arg0);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BeginMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PBStreamReader obj = (PBStreamReader)ToLua.CheckObject(L, 1, typeof(PBStreamReader));
			int arg0;
			bool o = obj.BeginMessage(out arg0);
			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushinteger(L, arg0);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EndMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PBStreamReader obj = (PBStreamReader)ToLua.CheckObject(L, 1, typeof(PBStreamReader));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.EndMessage(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}
}

