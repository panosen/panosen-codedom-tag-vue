using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-dialog
    /// </summary>
    public class ElDialogComponent : ElementComponent
    {
        /// <summary>
        /// el-dialog
        /// </summary>
        public override string Name { get; set; } = "el-dialog";
    }

    /// <summary>
    /// ElDialogComponentExtension
    /// </summary>
    public static class ElDialogComponentExtension
    {
        /// <summary>
        /// type="${type}"
        /// </summary>
        public static TElDialogComponent _VisibleSync<TElDialogComponent>(this TElDialogComponent elDialogComponent, string visibleSync)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty(":visible.sync", visibleSync);


            return elDialogComponent;
        }

        /// <summary>
        /// width
        /// </summary>
        public static TElDialogComponent Width<TElDialogComponent>(this TElDialogComponent elDialogComponent, int width)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty("width", width);

            return elDialogComponent;
        }

        /// <summary>
        /// width
        /// </summary>
        public static TElDialogComponent Width<TElDialogComponent>(this TElDialogComponent elDialogComponent, string width)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty("width", width);

            return elDialogComponent;
        }

        /// <summary>
        /// height
        /// </summary>
        public static TElDialogComponent Height<TElDialogComponent>(this TElDialogComponent elDialogComponent, int height)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty("height", height);

            return elDialogComponent;
        }

        /// <summary>
        /// height
        /// </summary>
        public static TElDialogComponent Height<TElDialogComponent>(this TElDialogComponent elDialogComponent, string height)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty("height", height);

            return elDialogComponent;
        }

        /// <summary>
        /// title
        /// </summary>
        public static TElDialogComponent Title<TElDialogComponent>(this TElDialogComponent ElDialogComponent, string title)
            where TElDialogComponent : ElDialogComponent
        {
            ElDialogComponent.AddProperty("title", title);

            return ElDialogComponent;
        }

        /// <summary>
        /// show-close="${showClose}"
        /// </summary>
        public static TElDialogComponent ShowClose<TElDialogComponent>(this TElDialogComponent elDialogComponent, string showClose)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty("show-close", showClose);

            return elDialogComponent;
        }

        /// <summary>
        /// show-close="${showClose}"
        /// </summary>
        public static TElDialogComponent _ShowClose<TElDialogComponent>(this TElDialogComponent elDialogComponent, string showClose)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty(":show-close", showClose);

            return elDialogComponent;
        }

        /// <summary>
        /// :close-on-click-modal="${closeOnClickModal}"
        /// </summary>
        public static TElDialogComponent _CloseOnClickModal<TElDialogComponent>(this TElDialogComponent elDialogComponent, BooleanValue closeOnClickModal)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty(":close-on-click-modal", closeOnClickModal.Value);

            return elDialogComponent;
        }

        /// <summary>
        /// :close-on-press-escape="${closeOnPressEscape}"
        /// </summary>
        public static TElDialogComponent _CloseOnPressEscape<TElDialogComponent>(this TElDialogComponent elDialogComponent, BooleanValue closeOnPressEscape)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddProperty(":close-on-press-escape", closeOnPressEscape.Value);

            return elDialogComponent;
        }

        /// <summary>
        /// 阻止默认提交表单
        /// </summary>
        public static TElDialogComponent PreventDefaultSubmit<TElDialogComponent>(this TElDialogComponent elDialogComponent)
            where TElDialogComponent : ElDialogComponent
        {
            elDialogComponent.AddAttribute("@submit.native.prevent");

            return elDialogComponent;
        }
    }
}
