using System.IO;
using UnityEngine;
using XLua;

/// <summary>
/// Lua管理器
/// </summary>
public class LuaMgr : BaseManager<LuaMgr>
{
    private LuaEnv luaEnv;

    /// <summary>
    /// 初始化
    /// </summary>
    public void Init()
    {
        luaEnv = new LuaEnv();

        luaEnv.AddLoader(MyCustomLoader);//Editor

        luaEnv.AddLoader(MyCustomLoaderFormAB);//AB
    }

    /// <summary>
    /// lua大G表
    /// </summary>
    public LuaTable Global
    {
        get
        {
            return luaEnv.Global;
        }
    }

    /// <summary>
    /// Editor模式
    /// </summary>
    /// <param name="filepath"></param>
    /// <returns></returns>
    private byte[] MyCustomLoader(ref string filepath)
    {
        Debug.Log(filepath);
        string path = Application.dataPath + "/Lua/" + filepath + ".lua";
        if (File.Exists(path))
        {
            return File.ReadAllBytes(path);
        }
        else
            Debug.Log("MyCustomLoader重定向失败");
        return null;
    }

    /// <summary>
    /// 发布模式 从AB包加载Lua文件
    /// </summary>
    /// <param name="filepath"></param>
    /// <returns></returns>
    private byte[] MyCustomLoaderFormAB(ref string filepath)
    {
        TextAsset file2 = ABMgr.GetInstance().LoadRes<TextAsset>("lua", filepath + ".lua");
        if (file2 != null)
            return file2.bytes;
        else
            Debug.Log("MyCustomLoaderFormAB重定向失败");
        return null;
    }

    /// <summary>
    /// 执行lua文件
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="formWhere"></param>
    public void DoLuaFile(string fileName, string formWhere = null)
    {
        string str = string.Format("require('{0}')", fileName);
        luaEnv.DoString(str);
    }

    /// <summary>
    /// 执行Lua脚本
    /// </summary>
    /// <param name="luaScript"></param>
    /// <param name="fromWhere"></param>
    public void DoString(string luaScript, string fromWhere = null)
    {
        luaEnv.DoString(luaScript, fromWhere);
    }

    /// <summary>
    /// 释放垃圾
    /// </summary>
    public void Tick()
    {
        luaEnv.Tick();
    }

    /// <summary>
    /// 销毁
    /// </summary>
    public void Dispose()
    {
        luaEnv.Tick();
        luaEnv.Dispose();
    }
}
