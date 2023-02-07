using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-model修饰符
    /// </summary>
    public enum VOnModifiers
    {
        /// <summary>
        /// v-model=""
        /// </summary>
        None = 0,

        /// <summary>
        /// call event.stopPropagation().
        /// </summary>
        StopPropagation = 1,

        /// <summary>
        /// call event.preventDefault().
        /// </summary>
        PreventDefault = 2,

        /// <summary>
        /// add event listener in capture mode.
        /// </summary>
        Capture = 3,

        /// <summary>
        /// v-on:self=""
        /// </summary>
        Self = 4,

        /// <summary>
        /// v-on:native=""
        /// </summary>
        Native = 5,

        /// <summary>
        /// v-on:once=""
        /// </summary>
        Once = 6,

        /// <summary>
        /// v-on:left=""
        /// </summary>
        Left = 7,

        /// <summary>
        /// v-on:right=""
        /// </summary>
        Right = 8,

        /// <summary>
        /// v-on:middle=""
        /// </summary>
        Middle = 9,

        /// <summary>
        /// v-on:passive=""
        /// </summary>
        Passive = 10
    }

    /// <summary>
    /// v-on 扩展
    /// https://vuejs.org/v2/api/#v-on
    /// </summary>
    public static class VOnExtension
    {
        /// <summary>
        /// v-on
        /// </summary>
        public static TVueComponent VOn<TVueComponent>(this TVueComponent builder, string @event, string handler, VOnModifiers vOnModifiers = default)
            where TVueComponent : BasicComponent
        {
            switch (vOnModifiers)
            {
                case VOnModifiers.StopPropagation:
                    builder.AddProperty($"v-on:{@event}.stop", handler);
                    break;
                case VOnModifiers.PreventDefault:
                    builder.AddProperty($"v-on:{@event}.prevent", handler);
                    break;
                case VOnModifiers.Capture:
                    builder.AddProperty($"v-on:{@event}.capture", handler);
                    break;
                case VOnModifiers.Self:
                    builder.AddProperty($"v-on:{@event}.self", handler);
                    break;
                case VOnModifiers.Native:
                    builder.AddProperty($"v-on:{@event}.native", handler);
                    break;
                case VOnModifiers.Once:
                    builder.AddProperty($"v-on:{@event}.once", handler);
                    break;
                case VOnModifiers.Left:
                    builder.AddProperty($"v-on:{@event}.left", handler);
                    break;
                case VOnModifiers.Right:
                    builder.AddProperty($"v-on:{@event}.right", handler);
                    break;
                case VOnModifiers.Middle:
                    builder.AddProperty($"v-on:{@event}.middle", handler);
                    break;
                case VOnModifiers.Passive:
                    builder.AddProperty($"v-on:{@event}.passive", handler);
                    break;
                case VOnModifiers.None:
                default:
                    break;
            }

            return builder;
        }
    }
}
