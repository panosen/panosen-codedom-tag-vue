using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-pagination
    /// </summary>
    public class ElPaginationComponent : ElementComponent
    {
        /// <summary>
        /// el-pagination
        /// </summary>
        public override string Name { get; set; } = "el-pagination";
    }

    /// <summary>
    /// ElPaginationLayout
    /// </summary>
    [Flags]
    public enum ElPaginationLayout
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,

        /// <summary>
        /// total
        /// </summary>
        Total = 1,

        /// <summary>
        /// sizes
        /// </summary>
        Sizes = 2,

        /// <summary>
        /// prev
        /// </summary>
        Prev = 4,

        /// <summary>
        /// next
        /// </summary>
        Next = 8,

        /// <summary>
        /// pager
        /// </summary>
        Pager = 16,

        /// <summary>
        /// 跳转到...页
        /// </summary>
        Jumper = 32
    }

    /// <summary>
    /// ElPaginationComponentExtension
    /// </summary>
    public static class ElPaginationComponentExtension
    {
        /// <summary>
        /// background
        /// </summary>
        public static TElPaginationComponent Background<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent)
            where TElPaginationComponent : ElPaginationComponent
        {
            elPaginationComponent.AddAttribute("background");

            return elPaginationComponent;
        }

        /// <summary>
        /// @size-change
        /// </summary>
        public static TElPaginationComponent OnSizeChange<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, string sizeChange)
            where TElPaginationComponent : ElPaginationComponent
        {
            elPaginationComponent.AddProperty("@size-change", sizeChange);

            return elPaginationComponent;
        }

        /// <summary>
        /// @current-change
        /// </summary>
        public static TElPaginationComponent OnCurrentChange<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, string currentChange)
            where TElPaginationComponent : ElPaginationComponent
        {
            elPaginationComponent.AddProperty("@current-change", currentChange);

            return elPaginationComponent;
        }

        /// <summary>
        /// :current-page
        /// </summary>
        public static TElPaginationComponent _CurrentPage<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, string currentPage)
            where TElPaginationComponent : ElPaginationComponent
        {
            elPaginationComponent.AddProperty(":current-page", currentPage);

            return elPaginationComponent;
        }

        /// <summary>
        /// :page-sizes
        /// </summary>
        public static TElPaginationComponent _PageSizes<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, params int[] pageSizes)
            where TElPaginationComponent : ElPaginationComponent
        {
            if (pageSizes == null || pageSizes.Length == 0)
            {
                return elPaginationComponent;
            }

            elPaginationComponent.AddProperty(":page-sizes", $"[{string.Join(", ", pageSizes)}]");

            return elPaginationComponent;
        }

        /// <summary>
        /// :page-size
        /// </summary>
        public static TElPaginationComponent _PageSize<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, string pageSize)
            where TElPaginationComponent : ElPaginationComponent
        {
            elPaginationComponent.AddProperty(":page-size", pageSize);

            return elPaginationComponent;
        }

        /// <summary>
        /// layout
        /// </summary>
        public static TElPaginationComponent Layout<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, ElPaginationLayout elPaginationLayout)
            where TElPaginationComponent : ElPaginationComponent
        {
            if (elPaginationLayout == ElPaginationLayout.None)
            {
                return elPaginationComponent;
            }

            elPaginationComponent.AddProperty("layout", elPaginationLayout.ToString().ToLower());

            return elPaginationComponent;
        }

        /// <summary>
        /// :total
        /// </summary>
        public static TElPaginationComponent _Total<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, string total)
            where TElPaginationComponent : ElPaginationComponent
        {
            elPaginationComponent.AddProperty(":total", total);

            return elPaginationComponent;
        }

        /// <summary>
        /// :hide-on-single-page
        /// </summary>
        public static TElPaginationComponent _HideOnSinglePage<TElPaginationComponent>(this TElPaginationComponent elPaginationComponent, BooleanValue hideOnSinglePage)
            where TElPaginationComponent : ElPaginationComponent
        {
            elPaginationComponent.AddProperty(":hide-on-single-page", hideOnSinglePage.Value);

            return elPaginationComponent;
        }
    }
}
