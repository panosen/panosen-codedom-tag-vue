using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-popover
    /// https://element.eleme.cn/#/zh-CN/component/popover
    /// </summary>
    public class ElPopoverComponent : ElementComponent
    {
        /// <summary>
        /// el-form
        /// </summary>
        public override string Name { get; set; } = "el-popover";
    }

    /// <summary>
    /// top, right, bottom, left
    /// </summary>
    public enum ElPopoverLocation
    {
        /// <summary>
        /// none
        /// </summary>
        None,

        /// <summary>
        /// top
        /// </summary>
        Top,

        /// <summary>
        /// right
        /// </summary>
        Right,

        /// <summary>
        /// bottom
        /// </summary>
        Bottom,

        /// <summary>
        /// left
        /// </summary>
        Left
    }

    /// <summary>
    /// start, end
    /// </summary>
    public enum ElPopoverAlign
    {
        /// <summary>
        /// none
        /// </summary>
        None,

        /// <summary>
        /// start
        /// </summary>
        Start,

        /// <summary>
        /// end
        /// </summary>
        End
    }

    /// <summary>
    ///  click, focus, hover, manual
    /// </summary>
    public enum ElPopoverTrigger
    {
        /// <summary>
        /// none
        /// </summary>
        None,

        /// <summary>
        /// click
        /// </summary>
        Click,

        /// <summary>
        /// focus
        /// </summary>
        Focus,

        /// <summary>
        /// hover
        /// </summary>
        Hover,

        /// <summary>
        /// manual
        /// </summary>
        Manual
    }

    /// <summary>
    /// el-popover
    /// </summary>
    public static class ElPopoverComponentExtension
    {

        /// <summary>
        /// trigger="${trigger}"
        /// </summary>
        public static TElPopoverComponent Trigger<TElPopoverComponent>(this TElPopoverComponent elPopoverComponent, ElPopoverTrigger trigger)
            where TElPopoverComponent : ElPopoverComponent
        {
            switch (trigger)
            {
                case ElPopoverTrigger.Click:
                    elPopoverComponent.AddProperty("trigger", "click");
                    break;
                case ElPopoverTrigger.Focus:
                    elPopoverComponent.AddProperty("trigger", "focus");
                    break;
                case ElPopoverTrigger.Hover:
                    elPopoverComponent.AddProperty("trigger", "hover");
                    break;
                case ElPopoverTrigger.Manual:
                    elPopoverComponent.AddProperty("trigger", "manual");
                    break;
                case ElPopoverTrigger.None:
                default:
                    break;
            }

            return elPopoverComponent;
        }

        /// <summary>
        /// placement="${location}-{align}"
        /// </summary>
        public static TElPopoverComponent Placement<TElPopoverComponent>(this TElPopoverComponent elPopoverComponent, ElPopoverLocation location, ElPopoverAlign align = ElPopoverAlign.None)
            where TElPopoverComponent : ElPopoverComponent
        {
            var placements = new List<string>();

            switch (location)
            {
                case ElPopoverLocation.Top:
                    placements.Add("top");
                    break;
                case ElPopoverLocation.Right:
                    placements.Add("right");
                    break;
                case ElPopoverLocation.Bottom:
                    placements.Add("bottom");
                    break;
                case ElPopoverLocation.Left:
                    placements.Add("left");
                    break;
                case ElPopoverLocation.None:
                default:
                    break;
            }

            switch (align)
            {
                case ElPopoverAlign.Start:
                    placements.Add("start");
                    break;
                case ElPopoverAlign.End:
                    placements.Add("end");
                    break;
                case ElPopoverAlign.None:
                default:
                    break;
            }

            if (placements.Count > 0)
            {
                elPopoverComponent.AddProperty("placement", string.Join("-", placements));
            }

            return elPopoverComponent;
        }

        /// <summary>
        /// content="${content}"
        /// </summary>
        public static TElPopoverComponent Content<TElPopoverComponent>(this TElPopoverComponent elPopoverComponent, string content)
            where TElPopoverComponent : ElPopoverComponent
        {
            elPopoverComponent.AddProperty("content", content);

            return elPopoverComponent;
        }

        /// <summary>
        /// :content="${content}"
        /// </summary>
        public static TElPopoverComponent _Content<TElPopoverComponent>(this TElPopoverComponent elPopoverComponent, string content)
            where TElPopoverComponent : ElPopoverComponent
        {
            elPopoverComponent.AddProperty(":content", content);

            return elPopoverComponent;
        }
    }
}
