using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// @click.stop="do()"
    /// </summary>
    public interface IOnClick
    {
    }

    /// <summary>
    /// @click.stop="do()"
    /// </summary>
    public static class IOnClickExtension
    {
        /// <summary>
        /// @click.stop="do()"
        /// </summary>
        /// <returns></returns>
        public static TVueComponent OnClick<TVueComponent>(this TVueComponent component, string statement)
            where TVueComponent : BasicComponent, IOnClick
        {
            component.AddProperty("@click.stop", statement);

            return component;
        }
    }
}
