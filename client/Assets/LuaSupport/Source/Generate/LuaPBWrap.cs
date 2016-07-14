﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaPBWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("LuaPB");
		L.RegFunction("GetTestData", GetTestData);
		L.RegFunction("TestStream", TestStream);
		L.RegFunction("RegisterFile", RegisterFile);
		L.RegFunction("GetPool", GetPool);
		L.RegFunction("TagSize", TagSize);
		L.RegFunction("VarintSize32", VarintSize32);
		L.RegFunction("Int32Size", Int32Size);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTestData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = LuaPB.GetTestData();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestStream(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PBStreamWriter arg0 = (PBStreamWriter)ToLua.CheckObject(L, 1, typeof(PBStreamWriter));
			LuaPB.TestStream(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			LuaPB.RegisterFile(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			DescriptorPool o = LuaPB.GetPool();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TagSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int o = LuaPB.TagSize(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int VarintSize32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 1);
			int o = LuaPB.VarintSize32(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Int32Size(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int o = LuaPB.Int32Size(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

