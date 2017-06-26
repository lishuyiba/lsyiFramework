using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace lsyi.Core.InfrastructureCore
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 应用程序实现类，继承TypeFinder类型查找器
    /// 
    /// 搜索BIN下面的DLL进行反射查找
    /// 
    /// </summary>
    public class WebAppTypeFinder : TypeFinder
    {
        #region Fields

        private bool _ensureBinFolderAssembliesLoaded = true;
        private bool _binFolderAssembliesLoaded = false;

        #endregion

        #region Ctor

        public WebAppTypeFinder()
        {
            this._ensureBinFolderAssembliesLoaded = true;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets wether assemblies in the bin folder of the web application should be specificly checked for beeing loaded on application load. This is need in situations where plugins need to be loaded in the AppDomain after the application been reloaded.
        /// </summary>
        public bool EnsureBinFolderAssembliesLoaded
        {
            get { return _ensureBinFolderAssembliesLoaded; }
            set { _ensureBinFolderAssembliesLoaded = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a physical disk path of \Bin directory
        /// </summary>
        /// <returns>The physical path. E.g. "c:\inetpub\wwwroot\bin"</returns>
        public virtual string GetBinDirectory()
        {
            //if (HostingEnvironment.IsHosted)
            //{
            //    //hosted
            //    return HttpRuntime.BinDirectory;
            //}
            //else
            //{
            //    //not hosted. For example, run either in unit tests
            //    return AppDomain.CurrentDomain.BaseDirectory;
            //}
            return AppContext.BaseDirectory;
        }


        public override IList<Assembly> GetAssemblies()
        {
            if (this.EnsureBinFolderAssembliesLoaded && !_binFolderAssembliesLoaded)
            {
                _binFolderAssembliesLoaded = true;
                string binPath = GetBinDirectory();
                //binPath = _webHelper.MapPath("~/bin");
                LoadMatchingAssemblies(binPath);
            }

            return base.GetAssemblies();
        }
        #endregion
    }
}
