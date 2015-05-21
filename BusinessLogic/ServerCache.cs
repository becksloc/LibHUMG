using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Data;
namespace LibHUMG.BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public class ServerCache
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheName"></param>
        /// <param name="obj"></param>
        public static void Insert(string cacheName, object obj)
        {
            Insert(cacheName, obj, null, DateTime.MaxValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheName"></param>
        /// <param name="obj"></param>
        /// <param name="cacheKey"></param>
        public static void Insert(string cacheName, object obj, string cacheKey)
        {
            Insert(cacheName, obj);
            List<string> listName = Get(cacheKey) as List<string>;
            if (listName == null)
            {
                listName = new List<string>(); 
                listName.Add(cacheName);
            }
            else
            { 
                bool isexist = false;
                foreach (string keyname in listName)
                {
                    if (keyname == cacheName)
                    {
                        isexist = true;
                        break;
                    }
                }
                if (!isexist) listName.Add(cacheName);
            }
            Insert(cacheKey, listName, null, DateTime.MaxValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheName"></param>
        /// <param name="obj"></param>
        /// <param name="dep"></param>
        /// <param name="dt"></param>
        public static void Insert(string cacheName, object obj, CacheDependency dep, DateTime dt)
        {
            HttpRuntime.Cache.Insert(cacheName, obj, dep, dt, TimeSpan.Zero);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheName"></param>
        /// <returns></returns>
        public static object Get(string cacheName)
        {
            return HttpRuntime.Cache.Get(cacheName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheName"></param>
        public static void Remove(string cacheKey, bool all)
        {
            if (all)
            {
                List<string> listName = Get(cacheKey) as List<string>;
                if (listName != null)
                {
                    foreach (string name in listName)
                    {
                        Remove(name);
                        string fileCachedPath = storePath + name + ".xml";
                        if (System.IO.File.Exists(fileCachedPath))
                            System.IO.File.Delete(storePath);
                    }
                }
            }
            else
            {
                Remove(cacheKey);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheName"></param>
        public static void Remove(string cacheName)
        {
            HttpRuntime.Cache.Remove(cacheName);
        }

        static string storePath = HttpContext.Current.Server.MapPath("~/App_Data/");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <param name="ds"></param>
        public static void CacheDataSet2Xml(string cacheKey, DataSet ds)
        {
            string fileCachedPath = storePath + cacheKey + ".xml";
            if (!System.IO.Directory.Exists(storePath))
                System.IO.Directory.CreateDirectory(storePath);
            ds.WriteXml(fileCachedPath);
            Insert(cacheKey, ds, new CacheDependency(fileCachedPath), DateTime.MaxValue);
        }
    }
}
