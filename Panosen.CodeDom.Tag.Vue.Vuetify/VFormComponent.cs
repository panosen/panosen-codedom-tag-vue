using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// https://vuetifyjs.com/en/components/forms
    /// </summary>
    public class VFormComponent : VueComponent
    {
        public override string Name { get; set; } = "v-form";

        public VFormComponent Ref(string _ref)
        {
            this.AddProperty("ref", _ref);

            return this;
        }

        public VFormComponent _LazyValidation(BooleanValue lazyValidation)
        {
            this.AddProperty(":lazy-validation", lazyValidation.Value);

            return this;
        }

        //public FormBuilder Container(ContainerBuilder containerBuilder)
        //{
        //    SetChild(containerBuilder);

        //    return this;
        //}
    }
}
