using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public static class VRowComponentExtension
    {
        public static TVRowComponent NoGutters<TVRowComponent>( this TVRowComponent vRowComponent) where TVRowComponent : VRowComponent
        {
            vRowComponent.AddAttribute("no-gutters");

            return vRowComponent;
        }
    }
}
