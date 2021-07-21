using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-tag
    /// </summary>
    public class ElTagComponent : ElementComponent
    {
        /// <summary>
        /// el-tag
        /// </summary>
        public override string Name { get; set; } = "el-tag";
    }

    /// <summary>
    /// success/info/warning/danger
    /// </summary>
    public enum ElTagType
    {
        /// <summary>
        /// none
        /// </summary>
        None,

        /// <summary>
        /// 
        /// </summary>
        Success,

        /// <summary>
        /// info
        /// </summary>
        Info,

        /// <summary>
        /// warning
        /// </summary>
        Warning,

        /// <summary>
        /// danger
        /// </summary>
        Danger
    }

    /// <summary>
    /// medium / small / mini
    /// </summary>
    public enum ElTagSize
    {
        /// <summary>
        /// none
        /// </summary>
        None,

        /// <summary>
        /// medium
        /// </summary>
        Medium,

        /// <summary>
        /// small
        /// </summary>
        Small,

        /// <summary>
        /// mini
        /// </summary>
        Mini
    }

    /// <summary>
    /// dark / light / plain
    /// </summary>
    public enum ElTagEffect
    {
        /// <summary>
        /// none
        /// </summary>
        None,

        /// <summary>
        /// dark
        /// </summary>
        Dark,

        /// <summary>
        /// light
        /// </summary>
        Light,

        /// <summary>
        /// plain
        /// </summary>
        Plain
    }

    /// <summary>
    /// ElTagComponentExtension
    /// </summary>
    public static class ElTagComponentExtension
    {
        /// <summary>
        /// type="${type}"
        /// </summary>
        public static TElTagComponent SetType<TElTagComponent>(this TElTagComponent elTagComponent, ElTagType elTagType)
            where TElTagComponent : ElTagComponent
        {
            switch (elTagType)
            {
                case ElTagType.Success:
                    elTagComponent.AddProperty("type", "success");
                    break;
                case ElTagType.Info:
                    elTagComponent.AddProperty("type", "info");
                    break;
                case ElTagType.Warning:
                    elTagComponent.AddProperty("type", "warning");
                    break;
                case ElTagType.Danger:
                    elTagComponent.AddProperty("type", "danger");
                    break;
                case ElTagType.None:
                default:
                    break;
            }

            return elTagComponent;
        }

        /// <summary>
        /// type="${type}"
        /// </summary>
        public static TElTagComponent SetType<TElTagComponent>(this TElTagComponent elTagComponent, string elTagType)
            where TElTagComponent : ElTagComponent
        {
            elTagComponent.AddProperty("type", elTagType);

            return elTagComponent;
        }

        /// <summary>
        /// closable
        /// </summary>
        public static TElTagComponent SetClosable<TElTagComponent>(this TElTagComponent elTagComponent)
            where TElTagComponent : ElTagComponent
        {
            elTagComponent.AddAttribute("closable");

            return elTagComponent;
        }

        /// <summary>
        /// disable-transitions
        /// </summary>
        public static TElTagComponent SetDisableTransitions<TElTagComponent>(this TElTagComponent elTagComponent)
            where TElTagComponent : ElTagComponent
        {
            elTagComponent.AddAttribute("disable-transitions");

            return elTagComponent;
        }

        /// <summary>
        /// hit
        /// </summary>
        public static TElTagComponent SetHit<TElTagComponent>(this TElTagComponent elTagComponent)
            where TElTagComponent : ElTagComponent
        {
            elTagComponent.AddAttribute("hit");

            return elTagComponent;
        }

        /// <summary>
        /// color
        /// </summary>
        public static TElTagComponent SetColor<TElTagComponent>(this TElTagComponent elTagComponent, string color)
            where TElTagComponent : ElTagComponent
        {
            elTagComponent.AddAttribute("hit");

            return elTagComponent;
        }

        /// <summary>
        /// size
        /// </summary>
        public static TElTagComponent SetSize<TElTagComponent>(this TElTagComponent elTagComponent, ElTagSize size)
            where TElTagComponent : ElTagComponent
        {
            switch (size)
            {
                case ElTagSize.Medium:
                    elTagComponent.AddProperty("size", "medium");
                    break;
                case ElTagSize.Small:
                    elTagComponent.AddProperty("size", "small");
                    break;
                case ElTagSize.Mini:
                    elTagComponent.AddProperty("size", "mini");
                    break;
                case ElTagSize.None:
                default:
                    break;
            }

            return elTagComponent;
        }

        /// <summary>
        /// size
        /// </summary>
        public static TElTagComponent SetSize<TElTagComponent>(this TElTagComponent elTagComponent, string size)
            where TElTagComponent : ElTagComponent
        {
            elTagComponent.AddProperty("size", size);

            return elTagComponent;
        }

        /// <summary>
        /// effect
        /// </summary>
        public static TElTagComponent SetEffect<TElTagComponent>(this TElTagComponent elTagComponent, ElTagEffect effect)
            where TElTagComponent : ElTagComponent
        {
            switch (effect)
            {
                case ElTagEffect.Dark:
                    elTagComponent.AddProperty("effect", "dark");
                    break;
                case ElTagEffect.Light:
                    elTagComponent.AddProperty("effect", "light");
                    break;
                case ElTagEffect.Plain:
                    elTagComponent.AddProperty("effect", "plain");
                    break;
                case ElTagEffect.None:
                default:
                    break;
            }

            return elTagComponent;
        }

        /// <summary>
        /// effect
        /// </summary>
        public static TElTagComponent SetEffect<TElTagComponent>(this TElTagComponent elTagComponent, string effect)
            where TElTagComponent : ElTagComponent
        {
            elTagComponent.AddProperty("effect", effect);

            return elTagComponent;
        }
    }
}
