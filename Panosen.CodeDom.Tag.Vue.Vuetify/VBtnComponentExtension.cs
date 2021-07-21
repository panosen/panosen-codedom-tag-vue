using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public static class VBtnComponentExtension
    {
        public static VBTN_COMPONENT Color<VBTN_COMPONENT>(this VBTN_COMPONENT vbtnComponent, string color) where VBTN_COMPONENT : VBtnComponent
        {
            vbtnComponent.AddProperty("color", color);

            return vbtnComponent;
        }
    }
}
