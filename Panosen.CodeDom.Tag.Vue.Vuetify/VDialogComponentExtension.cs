using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public static class VDialogComponentExtension
    {

        public static VDialogComponent MaxWidth(this VDialogComponent vDialogComponent, IntValue maxWidth)
        {
            vDialogComponent.AddProperty("max-width", maxWidth.Value);

            return vDialogComponent;
        }


        public static VDialogComponent Scrollable(this VDialogComponent vDialogComponent)
        {
            vDialogComponent.AddAttribute("scrollable");

            return vDialogComponent;
        }


        public static VDialogComponent Persistent(this VDialogComponent vDialogComponent)
        {
            vDialogComponent.AddAttribute("persistent");

            return vDialogComponent;
        }


        public static VDialogComponent Persistent(this VDialogComponent vDialogComponent, string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return vDialogComponent;
            }

            vDialogComponent.AddProperty(":persistent", expression);

            return vDialogComponent;
        }
    }
}
