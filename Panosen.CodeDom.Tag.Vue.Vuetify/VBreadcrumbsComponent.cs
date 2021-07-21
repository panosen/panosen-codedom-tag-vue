using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// https://vuetifyjs.com/en/components/breadcrumbs
    /// </summary>
    public class VBreadcrumbsComponent : VuetifyComponent
    {
        /// <summary>
        /// v-breadcrumbs
        /// </summary>
        public override string Name { get; set; } = "v-breadcrumbs";

        /// <summary>
        /// :items="items"
        /// </summary>
        /// <param name="items">默认值：[]</param>
        /// <returns></returns>
        public VBreadcrumbsComponent _Items(string items)
        {
            this.AddProperty(":items", items);

            return this;
        }

        /// <summary>
        /// divider="&gt;"
        /// </summary>
        /// <param name="divider">默认值：'/'</param>
        /// <returns></returns>
        public VBreadcrumbsComponent Divider(string divider)
        {
            this.AddProperty("divider", divider);

            return this;
        }

        /// <summary>
        /// 是否大号字体
        /// </summary>
        /// <param name="large"></param>
        /// <returns></returns>
        public VBreadcrumbsComponent _Large(BooleanValue large)
        {
            this.AddProperty(":large", large.Value);

            return this;
        }
    }
}
