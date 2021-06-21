using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-breadcrumb
    /// </summary>
    public class ElBreadcrumbComponent : ElementComponent
    {
        /// <summary>
        /// el-breadcrumb
        /// </summary>
        public override string Name { get; set; } = "el-breadcrumb";
    }

    /// <summary>
    /// ElBreadcrumbComponentExtension
    /// </summary>
    public static class ElBreadcrumbComponentExtension
    {
        /// <summary>
        /// separator
        /// </summary>
        /// <typeparam name="TElBreadcrumbComponent"></typeparam>
        /// <param name="elBreadcrumbComponent"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static TElBreadcrumbComponent Separator<TElBreadcrumbComponent>(this TElBreadcrumbComponent elBreadcrumbComponent, string separator)
            where TElBreadcrumbComponent : ElBreadcrumbComponent
        {
            elBreadcrumbComponent.AddProperty("separator", separator);

            return elBreadcrumbComponent;
        }
    }
}
